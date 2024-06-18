USE MvcCrudAdo;


create table Users(
Id int primary key Identity (1,1),
Name varchar(50),
Email varchar(50),
Age int
);

SELECT * FROM Users;


-- creating store procedure

Create proc sp_insert
@name varchar(50),
@email varchar(50),
@age int
as
begin
	insert into Users values(@name, @email, @age)
end;


-- Update store proc

create proc sp_update
@name varchar(50),
@email varchar(50),
@age int,
@id int
as
begin
	update Users set Name=@name, Email=@email, Age=@age where Id=@id
end;


-- Delete store proc

create proc sp_delete
@id int
as
begin
	delete from Users where Id=@id
end;


-- Selete / Read store proc

create proc sp_select
as
begin
	select * from Users
end;





