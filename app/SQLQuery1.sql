select* from EUsers;

insert into EUsers  (knumber,nombre,contrasena,rol) values ('k9813491827','nombre','contrasena','rh');


delete from EUsers where contrasena = 'contrasena';

update EUsers
set Knumber = 'k1001799', rol = 'superdios'
where rol = RH;


select* from IntranetSecurity order by EmployeeName;

select distinct Role from IntranetSecurity;

select EmployeeName from IntranetSecurity where Role = 'Supervisor';

select count (*)
from IntranetSecurity
where id > 300;

SELECT TOP 3 * FROM IntranetSecurity;

SELECT MIN(LenghtMAX)
FROM PackingPrices;

select max(LenghtMAX)
from PackingPrices;

select * from PackingPrices;


SELECT COUNT(DISTINCT Price)
FROM Products;
