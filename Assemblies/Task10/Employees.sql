CREATE DATABASE EmpDB;
GO
USE EmpDB;
GO
CREATE TABLE Employees (
    EmpNo     INT PRIMARY KEY,
    EmpName   VARCHAR(50),
    EmpSal    DECIMAL(10, 2),
    EmpJob    VARCHAR(50),
    EmpDeptNo INT
);
GO
INSERT INTO Employees VALUES
(101, 'Rajesh', 55000, 'Manager',   10),
(102, 'Priya',  42000, 'Developer', 20),
(103, 'Arjun',  38000, 'Tester',    20),
(104, 'Sneha',  47000, 'Analyst',   30),
(105, 'Kiran',  30000, 'Clerk',     10);
GO
SELECT * FROM Employees;
GO
