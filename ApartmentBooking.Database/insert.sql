USE DBBookings
GO

INSERT INTO tblRoomType(TypeOfRoom, RoomCount)
VALUES 
('Single Room',1),
('Double Room',2),
('Deluxe Room',2),
('Family Suite',3),
('Premium Suite',3)

INSERT INTO tblGuest(FirstName, SecondName)
VALUES
('Oleksii','Shevchuk'),
('Dmitro','Kolomiets'),
('Vladislav','Dovzhenko'),
('Oleg','Yazepov'),
('Olena','Zavadetska'),
('Iryna','Petranovska'),
('Oleksii','Pietukhov'),
('Igor','Chipak')

INSERT INTO tblRoom(RoomTypeId, Number, PlacesCount, Rate)
VALUES
--Single Room
(1, '101', 1, 50.00),
(1, '102', 1, 50.00),
(1, '103', 1, 50.00),
(1, '104', 1, 50.00),
(1, '105', 2, 75.00),
(1, '106', 2, 75.00),
(1, '107', 2, 75.00),
(1, '108', 2, 75.00),

--Double Room
(2, '201', 2, 100.00),
(2, '202', 2, 100.00),
(2, '203', 2, 100.00),
(2, '204', 2, 100.00),
(2, '205', 4, 125.00),
(2, '206', 4, 125.00),
(2, '207', 4, 125.00),
(2, '208', 4, 125.00),

--Deluxe Room
(3, '301', 4, 150.00),
(3, '302', 4, 150.00),
(3, '303', 4, 150.00),
(3, '304', 4, 150.00),
(3, '305', 4, 150.00),
(3, '306', 4, 150.00),

-- Family Suite
(4, '307', 6, 250.00),
(4, '308', 6, 250.00),
(4, '401', 6, 250.00),
(4, '402', 6, 250.00),
(4, '403', 6, 250.00),
(4, '404', 6, 250.00),

-- Premium Suite
(5, '405', 4, 400.00),
(5, '406', 4, 400.00)

INSERT INTO tblBooking(GuestId, RoomId, DateIn, DateOut, Cost)
VALUES
--Single Room
(1,1,'2016-04-02', '2016-04-06',200.00),
(2,5,'2016-03-24', '2016-03-27',225.00),

--Double Room
(3,9,'2016-04-01', '2016-04-07',600.00),
(4,15,'2016-03-23', '2016-03-27',500.00),

--Deluxe Room
(5,17,'2016-03-26', '2016-03-30',600.00),
(6,18,'2016-03-25', '2016-03-27',300.00),

-- Family Suite
(7,23,'2016-03-26', '2016-03-28',500.00),

-- Premium Suite
(8,29,'2016-03-27', '2016-03-30',1200.00)

SET IDENTITY_INSERT tblUser ON;

INSERT INTO tblUser(Id, FirstName, SecondName, [Login], [Password], [Disabled])
	VALUES 
		(1,'Vladyslav','Igorev', 'login_1', '57210b12af5e06ad2e6e54a93b1465aa', 0), -- Password: password_1
		(2,'Oleg','Gumeniuk', 'login_2', '259640f97ac2b4379dd540ff4016654c', 0),-- Password: password_2
		(3,'Olga','Kolodiy', 'login_3', '48ef85c894a06a4562268de8e4d934e1', 1) -- Password: password_3

SET IDENTITY_INSERT tblUser OFF;
