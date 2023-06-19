create table Employee (
	
	Id int IDENTITY(1,1) PRIMARY KEY ,
	FirstName varchar(50) NOT NUll,
	MiddleName Varchar(50),
	LastName varchar(50)NOT NUll,
	DOB Date NOT NUll,
	MobileNumber Varchar(10) NOT NUll,
	Address Varchar(100) NOT NUll
);

INSERT INTO Employee VALUES ('akash',NUll,'rana','1999-12-25','12346','Bandhani');
INSERT INTO Employee VALUES ('Jaimit',NUll,'rana','1996-12-15','12346','Bandhani');
INSERT INTO Employee VALUES ('Karan',NUll,'Raj','2002-07-10','12346','Vadodra');
INSERT INTO Employee VALUES ('Jainam',NUll,'Bhavsar','2023-06-08','12346','Nadiad');

UPDATE  Employee SET MiddleName='I';
UPDATE Employee SET FirstName='SQLPerson' Where Id='1';
DELETE FROM Employee Where Id='2';

Truncate Table Employee;
