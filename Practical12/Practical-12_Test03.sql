
create Table Designation(
	DesignationId int IDENTITY(1,1) PRIMARY KEY ,
	DesignationName varchar(10) NOT NUll
);

create table Employee (
	
	Id int IDENTITY(1,1) PRIMARY KEY ,
	FirstName varchar(50) NOT NUll,
	MiddleName Varchar(50),
	LastName varchar(50)NOT NUll,
	DOB Date NOT NUll,
	MobileNumber Varchar(10) NOT NUll,
	Address Varchar(100) NOT NUll,
	Salary Decimal(8,4) NOT NUll,
    DesignationId int FOREIGN KEY REFERENCES Designation(DesignationId)

);



SELECT COUNT(*) FROM Employee Group By DesignationId ;

SELECT FirstName,MiddleName,LastName,DesignationName FROM Employee FULL OUTER JOIN Designation ON Employee.DesignationId=Designation.DesignationId;

CREATE VIEW EmployeeView AS 
Select Id,FirstName, MiddleName, LastName,DesignationName, DOB,MobileNumber, Address,Salary FROM Employee FULL OUTER JOIN Designation ON Employee.DesignationId=Designation.DesignationId;


CREATE PROCEDURE InsertIntoDesignation @DesignationName varchar(30)
AS
INSERT INTO Designation VALUES (@DesignationName)
GO
EXEC InsertIntoDesignation @DesignationName = 'Manger';


CREATE PROCEDURE InsertIntoEmployee @FirstName varchar(50),@MiddleName varchar(50),@LastName varchar(50),@DOB Date ,@MobileNumber varchar(10),@Address varchar(100),@Salary decimal(8,4),@DesignationId int
AS
INSERT INTO Employee VALUES (@FirstName,@MiddleName,@LastName,@DOB,@MobileNumber,@Address,@Salary,@DesignationId)
GO

EXEC InsertIntoEmployee @FirstName='jainam',@MiddleName=NUll,@LastName='Bhavsar',@DOB='2001-10-25' ,@MobileNumber='156462656',@Address='akjsadnidw',@Salary=500,@DesignationId='1';

SELECT DesignationName FROM Designation Where DesignationId=(SELECT DesignationId FROM Employee GROUP BY DesignationId HAVING COUNT(*) > 1);

CREATE PROCEDURE SelectEmployee 
AS
Select Id, FirstName, MiddleName, LastName, DesignationName, DOB, MobileNumber, Address,Salary FROM Employee FULL OUTER JOIN Designation ON Employee.DesignationId=Designation.DesignationId ORDER BY DOB;

GO

EXEC SelectEmployee ;

CREATE PROCEDURE SelectEmployee1 @DesignationId int
AS
Select  Id, FirstName, MiddleName, LastName, DesignationName, DOB, MobileNumber, Address,Salary FROM Employee FULL OUTER JOIN Designation ON Employee.DesignationId=Designation.DesignationId ORDER BY FirstName;
GO

EXEC SelectEmployee1 @DesignationId=1 ;

CREATE NONCLUSTERED INDEX IX_Employee_DesignationId
ON Employee (DesignationId);


SELECT MAX(Salary) FROM Employee;