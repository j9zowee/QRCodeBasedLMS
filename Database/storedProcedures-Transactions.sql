use dbLibraryManagement

CREATE PROCEDURE sp_BorrowBook
@BorrowNum varchar(50),
@SchoolID varchar(50),
@BookNum varchar(50),
@BorrowedDate datetime,
@DueDate datetime

AS
BEGIN
	DECLARE @libUserID int
	Declare @bookID int
	select @libUserID = dbo.tblLibraryUser.lib_UserID FROM  dbo.tblLibraryUser where dbo.tblLibraryUser.lib_SchoolID = @SchoolID
	select @bookID = dbo.tblBook.book_BookID FROM dbo.tblBook where tblBook.book_BookNum = @BookNum
	insert into tblBorrow values(@BorrowNum,@libUserID,@bookID,@BorrowedDate,@DueDate)
END

CREATE PROCEDURE sp_Attendance
@StudentID varchar(50),
@Firstname varchar(50),
@Lastname varchar(50),
@LoginTime datetime

AS
BEGIN
	insert into tblAttendance values(@StudentID,@Firstname,@Lastname,@LoginTime)
END

select * from tblAttendance