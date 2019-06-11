CREATE DATABASE StudentDb

--CREATE TABLE Students(
--ID int,
--Name VARCHAR(100),
--Age int
--)

CREATE TABLE Students(
ID int IDENTITY(1,1),
Name VARCHAR(100),
Age int
)


SELECT * FROM Students

INSERT INTO Students(Name,Age) VALUES ('Sadik',23)
INSERT INTO Students(Name,Age) VALUES ('Shibly',23)
INSERT INTO Students(Name,Age) VALUES ('Shaheen',25)



Delete Students WHERE Name='Sadik'
UPDATE Students SET Age=24 WHERE Name='Shibly'

DROP TABLE Students

