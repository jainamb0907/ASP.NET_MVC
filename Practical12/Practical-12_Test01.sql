create table Employee (
	
	Id int IDENTITY(1,1) PRIMARY KEY ,
	FirstName varchar(50) NOT NUll,
	MiddleName Varchar(50),
	LastName varchar(50)NOT NUll,
	DOB Date NOT NUll,
	MobileNumber Varchar(10) NOT NUll,
	Address Varchar(100) NOT NUll,
	Salary Decimal(8,4) NOT NUll
);
INSERT INTO Employee VALUES ('akash','I','rana','1999-12-25','12346','Bandhani',1000);
INSERT INTO Employee VALUES ('Jaimit',NUll,'rana','1996-12-15','12346','Bandhani',2000);
INSERT INTO Employee VALUES ('Karan',NUll,'Raj','2002-07-10','12346','Vadodra',3000);
INSERT INTO Employee VALUES ('Jainam',NUll,'Bhavsar','2023-06-08','12346','Nadiad',4000);

SELECT SUM(Salary) AS Total_Salary FROM Employee;

SELECT * FROM Employee Where DOB < '2000-01-01';

SELECT COUNT(*) FROM Employee Where MiddleName=NUll;
