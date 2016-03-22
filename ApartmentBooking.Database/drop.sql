USE DBBookings
GO

DROP PROC spExtendOrder;
DROP PROC spGetAllHotelRoomsInformation;
DROP PROC spGetAvailableRoomsByDate;
DROP PROC spGetGuestIdByFullName;
DROP PROC spGetPriceList;
DROP PROC spGetRoomInformation;
DROP PROC spMakeOrder;

DROP TABLE tblBooking
DROP TABLE tblRoom
DROP TABLE tblGuest
DROP TABLE tblRoomType
DROP TABLE tblUser

USE MASTER
GO
DROP DATABASE DBBookings



