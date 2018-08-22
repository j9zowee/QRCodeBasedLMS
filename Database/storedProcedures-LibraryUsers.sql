use dbLibraryManagement

CREATE PROCEDURE sp_AddLibraryUser
@SchoolID varchar(50),
@Firstname varchar(100),
@Lastname varchar(100),
@Gender varchar(10),
@Address varchar(100),
@ContactNumber varchar(50),
@UserType varchar(50),
@SchoolYear varchar(50)

AS
BEGIN
	insert into tblLibraryUser values(@SchoolID,@Firstname,@Lastname,@Gender,@Address,@ContactNumber,@UserType,@SchoolYear)
END


CREATE PROCEDURE sp_ViewLibraryUser
@SchoolYear varchar(50)

AS
BEGIN
	select * from tblLibraryUser where tblLibraryUser.lib_SchoolYear = @SchoolYear
END