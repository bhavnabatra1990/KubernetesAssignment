create database EmployeeDb;

GO

USE EmployeeDb


CREATE TABLE Employee ( Id INT NOT NULL Identity, FirstName VARCHAR(255) NOT NULL, LastName VARCHAR(255) NOT NULL, Age INT NOT NULL, Address VARCHAR(255) NOT NULL, Salary INT NOT NULL, PhoneNumber VARCHAR(255) NOT NULL, PRIMARY KEY (Id) )

GO

INSERT INTO Employee (FirstName, LastName, Age, Address, Salary, PhoneNumber) VALUES ('John1', 'Doe1', 25, '123 Main St1', 50000, '555-555-5555')
INSERT INTO Employee (FirstName, LastName, Age, Address, Salary, PhoneNumber) VALUES ('John2', 'Doe2', 25, '123 Main St2', 50000, '555-555-5555')
INSERT INTO Employee (FirstName, LastName, Age, Address, Salary, PhoneNumber) VALUES ('John3', 'Doe3', 25, '123 Main St3', 50000, '555-555-5555')
INSERT INTO Employee (FirstName, LastName, Age, Address, Salary, PhoneNumber) VALUES ('John4', 'Doe4', 25, '123 Main St4', 50000, '555-555-5555')
INSERT INTO Employee (FirstName, LastName, Age, Address, Salary, PhoneNumber) VALUES ('John5', 'Doe5', 25, '123 Main St5', 50000, '555-555-5555')
INSERT INTO Employee (FirstName, LastName, Age, Address, Salary, PhoneNumber) VALUES ('John6', 'Doe6', 25, '123 Main St6', 50000, '555-555-5555')
INSERT INTO Employee (FirstName, LastName, Age, Address, Salary, PhoneNumber) VALUES ('John7', 'Doe7', 25, '123 Main St7', 50000, '555-555-5555')
INSERT INTO Employee (FirstName, LastName, Age, Address, Salary, PhoneNumber) VALUES ('John8', 'Doe8', 25, '123 Main St8', 50000, '555-555-5555')
