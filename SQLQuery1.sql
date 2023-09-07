create database SSchool
Use SSchool

Create Table Students(
Id int primary key,
StudentsName nvarchar(50),
StudentClass int,
StudentsObtainMarks int 
);
insert into Students values (1,'Aman Goyal',12,45),(2,'Johny ',11,38);
select *from Students