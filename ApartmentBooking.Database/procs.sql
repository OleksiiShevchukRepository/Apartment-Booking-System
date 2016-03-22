USE DBBookings;
GO

--spGetPriceList
CREATE PROC spGetPriceList
AS
BEGIN
	SELECT DISTINCT t.TypeOfRoom, r.Rate,r.PlacesCount
	FROM tblRoom r
	JOIN tblRoomType t on r.RoomTypeId = t.Id
	ORDER BY r.Rate ASC
END
GO

--spGetAllHotelRoomsInformation
CREATE PROC spGetAllHotelRoomsInformation
AS
BEGIN
	SELECT  r.Id, r.Number, r.Rate, r.PlacesCount, t.Id, t.TypeOfRoom, t.RoomCount
	FROM tblRoom r
	JOIN tblRoomType t ON r.RoomTypeId = t.Id
	ORDER BY r.Number
END
GO

--spGetAvailableRoomsByDate
CREATE PROC spGetAvailableRoomsByDate
@date DATE
AS
BEGIN

	SELECT r.Id, r.Number, r.Rate, r.PlacesCount, t.Id, t.TypeOfRoom, t.RoomCount
	FROM tblRoom r 
	JOIN tblRoomType t ON r.RoomTypeId = t.Id
	WHERE r.Id NOT IN 
	(
		SELECT b.RoomId 
		FROM tblBooking b
		WHERE @date >= b.DateIn AND @date < b.DateOut
	)
END
GO

--spGetRoomInformation
CREATE PROC spGetRoomInformation
@roomNumber NVARCHAR(10)
AS
BEGIN
	IF NOT EXISTS (SELECT 1 FROM tblRoom WHERE Number = @roomNumber)
		BEGIN
			THROW 60001, 'Number not found', 100;
		END

	SELECT r.Id, r.Number, r.Rate, r.PlacesCount, t.Id, t.TypeOfRoom, t.RoomCount
	FROM tblRoom r
	JOIN tblRoomType t ON r.RoomTypeId = t.Id
	WHERE r.Number = @roomNumber
END
GO

--spGetGuestIdByFullName
CREATE PROC spGetGuestIdByFullName
@firstName NVARCHAR(50),
@secondName NVARCHAR(50),

@guestId INT OUTPUT
AS
BEGIN

	IF EXISTS ( 
				SELECT 1 
				FROM tblGuest 
				WHERE FirstName = @firstName and SecondName = @secondName
			  )
			BEGIN
				SET @guestId = (SELECT Id FROM tblGuest WHERE FirstName = @firstName AND SecondName = @secondName) 
			END
	else
		begin
			INSERT INTO tblGuest(FirstName, SecondName)
			VALUES (@firstName, @secondName);
			SET @guestId = Scope_identity();
		END
END
GO

--spMakeOrder
CREATE PROC spMakeOrder
@firstName NVARCHAR(50),
@secondName NVARCHAR(50),
@roomNumber NVARCHAR(10),
@dateIn DATE,
@dateOut DATE

AS
BEGIN

	DECLARE @guestId INT; 
	DECLARE @roomId INT; 
	DECLARE @days INT; 
	DECLARE @rate NUMERIC(18,2); 
	DECLARE @cost NUMERIC(18,2); 
	DECLARE @dateNow DATE = GETDATE();

	IF(@dateIn = @dateOut)
		BEGIN
			THROW 60003, '@dateIn and @dateOut are equal', 100;
		END
	IF (DATEDIFF(DAY, @dateIn, @dateNow) >= 1 or DATEDIFF(DAY, @dateOut, @dateNow) >= 1)
		BEGIN
			THROW 60004, 'Invalid DateIn or DateOut', 100;
		END
	IF EXISTS(
				SELECT 1 
				FROM tblBooking 
				WHERE RoomId = (SELECT Id FROM tblRoom WHERE Number = @roomNumber) AND (@dateIn >= DateIn AND  @dateIn < DateOut)
				OR (RoomId = (SELECT Id FROM tblRoom WHERE Number = @roomNumber)AND (@dateOut > DateIn AND @dateOut < DateOut))
			 )
		BEGIN
			THROW 60003, 'Room ia already taken on this date', 100;
		END

	SET @roomId = (SELECT Id FROM tblRoom WHERE Number = @roomNumber)
	SET @days = DATEDIFF(DAY,@dateIn, @dateOut);
	SET @rate = (SELECT rate FROM tblRoom WHERE Number = @roomNumber)
	SET @cost = @rate * @days;

	exec spGetGuestIdByFullName
	@firstName  = @firstName,
	@secondName = @secondName,
	@guestId  = @guestId OUTPUT

	INSERT INTO tblBooking (GuestId, RoomId, DateIn, DateOut, Cost)
	VALUES (@guestId, @roomId, @dateIn, @dateOut, @cost);	
	
END
GO

--spExtendOrder
CREATE PROC spExtendOrder

	@roomNumber NVARCHAR(10),
	@newDateOut DATE,
	@guestName NVARCHAR(50),
	@guestSurname NVARCHAR(50)

AS
BEGIN

	DECLARE @bookingId INT;
	DECLARE @rate NUMERIC(18,2);
	DECLARE @oldCost NUMERIC(18,2);
	DECLARE @newCost NUMERIC(18,2);
	DECLARE @days INT;

	IF (@newDateOut <= GETDATE())
		BEGIN
			THROW 60004, 'Entered new Out Date is less than today"s date', 100;
		END

	IF NOT EXISTS (
					SELECT 1 FROM tblBooking WHERE RoomId = (SELECT Id FROM tblRoom WHERE Number = @roomNumber)
					AND GuestId = (SELECT Id FROM tblGuest WHERE FirstName = @guestName AND SecondName = @guestSurname)
				   )
		BEGIN
			THROW 60005, 'This room or booking does not exist', 100;
		END

	SET @bookingId = (
					   SELECT TOP(1) Id 
					   FROM tblBooking 
					   WHERE RoomId = (SELECT Id FROM tblRoom WHERE Number = @roomNumber)
					   and GuestId = (SELECT Id FROM tblGuest WHERE FirstName = @guestName AND SecondName = @guestSurname)
					   ORDER BY DateIn DESC
					  )

	IF (@newDateOut  <= (SELECT DateOut FROM tblBooking WHERE Id = @bookingId))
		BEGIN
			THROW 60006, 'Invalid  Date Out', 100;
		END

	SET @rate = (
					SELECT Rate 
					FROM tblRoom 
					WHERE Id = (SELECT RoomId FROM tblBooking WHERE Id = @bookingId)
				)
	--SET @days = CAST(@newDateOut - (SELECT dateOut FROM tblBooking WHERE Id = @bookingId) AS INT);
	SET @days = DATEDIFF(DAY, (SELECT dateOut FROM tblBooking WHERE Id = @bookingId), @newDateOut);
	SET @oldCost = (SELECT Cost FROM tblBooking WHERE Id = @bookingId);
	SET @newCost = @oldCost +	(@rate * @days);

	UPDATE tblBooking
	SET DateOut = @newDateOut, Cost = @newCost
	WHERE Id = @bookingId

END
GO

--spGetUserByLogin
CREATE PROC spGetUserByLogin
@login NVARCHAR(50),
@password NVARCHAR(50)

AS
BEGIN

	SELECT Id, FirstName, SecondName, [Login], [Disabled]
	FROM tblUser
	WHERE [Login] = @login and [Password] = @password and [Disabled] <> 1

END;
GO

--spGetAllBookings
CREATE PROC spGetAllBookings
AS
BEGIN 

	SELECT  g.Id, g.FirstName, g.SecondName, r.Id, r.Number, r.Rate, r.PlacesCount, b.Id, b.dateIn, b.DateOut, b.Cost
	FROM tblBooking b
	JOIN tblGuest g on b.GuestId = g.Id
	JOIN tblRoom r on b.RoomId = r.Id
	WHERE b.GuestId = g.Id and b.RoomId = r.Id
	
END
GO


