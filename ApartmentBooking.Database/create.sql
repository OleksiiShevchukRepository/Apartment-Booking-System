	CREATE DATABASE DBBookings;
	GO

	USE DBBookings
	GO

	CREATE TABLE tblGuest
	(	
		Id INT NOT NULL IDENTITY(1,1),
		FirstName NVARCHAR(50) NOT NULL,
		SecondName NVARCHAR(50) NOT NULL,
		CONSTRAINT PK_tblGuest_Id PRIMARY KEY(ID),
	);
	
	CREATE TABLE tblRoomType
	(	
		Id INT NOT NULL IDENTITY(1,1),
		TypeOfRoom NVARCHAR(20) NOT NULL,
		RoomCount INT NOT NULL,
		CONSTRAINT PK_tblRoomType_Id PRIMARY KEY(Id)
	);
	
	CREATE TABLE tblRoom
	(	
		Id INT NOT NULL IDENTITY(1,1),
		RoomTypeId INT NOT NULL,
		Number NVARCHAR(10) NOT NULL,
		PlacesCount INT NOT NULL,
		Rate NUMERIC(18,2) NOT NULL,
		CONSTRAINT PK_tblRoom_Id PRIMARY KEY(ID),
		CONSTRAINT FK_tblRoom_RoomTypeId_tblRoomType_Id FOREIGN KEY(RoomTypeId) REFERENCES tblRoomType(Id),
		CONSTRAINT CK_tblRoom_Rate CHECK(Rate > 0),
		CONSTRAINT UQ_tblRoom_Number UNIQUE(Number)
	);
	
	CREATE TABLE tblBooking
	(	
		Id INT NOT NULL IDENTITY(1,1),
		GuestId INT NOT NULL,
		RoomId INT NOT NULL,
		DateIn DATE NOT NULL,
		DateOut DATE NOT NULL,
		Cost NUMERIC(18,2)NOT NULL,
		CONSTRAINT PK_tblBooking_Id PRIMARY KEY(Id),
		CONSTRAINT FK_tblBooking_GuestId_tblGuest_Id FOREIGN KEY(GuestId) REFERENCES tblGuest(Id),
		CONSTRAINT FK_tblBooking_RoomId_tblRoom_Id FOREIGN KEY(RoomId) REFERENCES tblRoom(Id),
		CONSTRAINT CK_tblBooking_DateIn_DateOut CHECK(DateOut > DateIn)
	);
	
	CREATE TABLE tblUser
	(
		Id INT NOT NULL IDENTITY(1,1),
		FirstName NVARCHAR(50) NOT NULL,
		SecondName NVARCHAR(50) NOT NULL,
		[Login] VARCHAR(50) NOT NULL,
		[Password] VARCHAR(50) NOT NULL,
		[Disabled] BIT NOT NULL,
		CONSTRAINT PK_tblUser_Id PRIMARY KEY (Id),
		CONSTRAINT UQ_tblUser_Login UNIQUE ([Login])
	);
