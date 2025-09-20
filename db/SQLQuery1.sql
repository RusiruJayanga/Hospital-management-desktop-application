create table users
(
 id int primary key identity(1, 1),
 username varchar(max) null,
 password varchar(max) null,
)



select * from users