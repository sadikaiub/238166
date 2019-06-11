CREATE DATABASE StudentDb

--CREATE TABLE Students(
--ID int,
--Name VARCHAR(100),
--Age int
--)

CREATE TABLE Students(
ID int IDENTITY(100,1),
RollNo int,
Name VARCHAR(100),
Age int,
Address VARCHAR(100),
District VARCHAR(100)
)


SELECT * FROM Students

INSERT INTO Students(RollNo,Name,Age,Address,District) VALUES (1,'Sadik',22,'Road:11,House:19,Sector:5','Mymensingh')
INSERT INTO Students(RollNo,Name,Age,Address,District) VALUES (1,'Shibly',22,'Road:03,House:11,Sector:10','Dhaka')
INSERT INTO Students(RollNo,Name,Age,Address,District) VALUES (1,'Sabbir',22,'Road:09,House:88,Sector:3','Chittagong')
INSERT INTO Students(RollNo,Name,Age,Address,District) VALUES (1,'Shaheen',22,'Road:19,House:30,Sector:5','Barishal')
INSERT INTO Students(RollNo,Name,Age,Address,District) VALUES (1,'Niloy',22,'Road:18,House:12,Sector:8','Rangpur')


CREATE TABLE District(
ID int IDENTITY(100,1),
Name VARCHAR(100)
)

INSERT INTO District(Name) VALUES('Mymensingh')
INSERT INTO District(Name) VALUES('Dhaka')
INSERT INTO District(Name) VALUES('Chittagong')
INSERT INTO District(Name) VALUES('Barishal')
INSERT INTO District(Name) VALUES('Rangpur')


CREATE TABLE Departments(
ID int IDENTITY(1,1),
Name VARCHAR(100)
)

INSERT INTO Departments(Name) VALUES('CSE')
INSERT INTO Departments(Name) VALUES('EEE')
INSERT INTO Departments(Name) VALUES('Civil')
INSERT INTO District(Name) VALUES('Mechanical')
INSERT INTO Departments(Name) VALUES('BBA')


CREATE TABLE Subject(
ID int IDENTITY(1,1),
Name VARCHAR(100),
Code int
)

INSERT INTO Subject(Name,Code) VALUES('Match',102)
INSERT INTO Subject(Name,Code) VALUES('English',103)
INSERT INTO Subject(Name,Code) VALUES('Physics',104)
INSERT INTO Subject(Name,Code) VALUES('Chamestry',105)

CREATE TABLE Marks(
ID int IDENTITY(1,1),
StudentId int,
DepartmentId int,
SubjectId int,
Mark int
)

SELECT * FROM Marks

SELECT s.Name,Age,Address,d.Name as District FROM Students as s
left outer join District as d
on s.District=d.ID



Delete Students WHERE Name='Sadik'
UPDATE Students SET Age=24 WHERE Name='Shibly'

DROP TABLE Students



