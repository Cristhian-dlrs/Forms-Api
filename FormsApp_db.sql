drop database if exists FormsApp_db;
go
create database FormsApp_db;
go
use FormsApp_db;
go

create table [user] 
(
	id int identity(1, 1) primary key,
	[email] varchar(50),
	[password] varchar(25) not null
);

create table form 
(
	id int identity(1, 1) primary key,
	[name] varchar(50) not null,
	userId int not null,

	foreign key (userId) references [user](id)
	on delete cascade
	on update cascade
);

create table question 
(
	id int identity(1, 1) primary key,
	[value] varchar(100) not null,
	formId int not null,

	foreign key (formId) references form(id)
	on delete cascade
	on update cascade
);

create table respondant 
(
    id int identity(1, 1) primary key,
	[name] varchar(50) not null,
	formId int not null,

    foreign key (formId) references form(id)
	on delete cascade
	on update cascade
);

create table answer 
(
	id int identity(1, 1) primary key,
	[value] varchar(100) not null,
	questionId int not null,
    respondantId int not null,

	foreign key (questionId) references question(id),
    foreign key (respondantId) references respondant(id)
	on delete cascade
	on update cascade
);