

create database vjezba


use vjezba


create table VehicleMake
(
Id int primary key identity(1,1),
 Name nvarchar(30)

)


Insert into VehicleMake values ('BMW')
Insert into VehicleMake values ('Ford')
Insert into VehicleMake values ('Opel')


create table VehicleModel
(
Id int primary key identity(1,1),
MakeId int,
Name  nvarchar(30),

  FOREIGN KEY (MakeId)  REFERENCES VehicleMake(Id)

) 
insert into VehicleModel values(1,'x5')
insert into VehicleModel values(2,'Orion 1.6b')

insert into VehicleModel values(3,'Calibra')
















