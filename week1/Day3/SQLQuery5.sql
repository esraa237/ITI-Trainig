create table Instructor(
id int primary key identity(1,1),
salary int default 3000,
overtime int unique,
BD date,
age as(year(getdate())-year(BD)),
netsal as(isnull(salary,0)+isnull(overtime,0)) persisted,
fname varchar(20),
lname varchar(20),
hiredate date,
address varchar(50),
constraint c7 check (address in ('cairo','alex')),
constraint c8 check (salary>=1000 and salary<=5000),
)
create table course (
CID int primary key identity,
CName varchar(50),
Duration varchar(20)
)
create table teach(
INID int,
CID int,
 constraint c1 primary key(INID,CID),
 constraint c2 foreign key (INID) references Instructor(id)
  on delete cascade on update cascade,
 constraint c3 foreign key (CID) references course(CID) 
 on delete cascade on update cascade
)
create table lab(
LID int identity,
CID int ,
location varchar(50),
capacity int,
constraint c4 primary key(LID,CID),
constraint c5 foreign key (CID) references course(CID)
  on delete cascade on update cascade,
constraint c6 check(capacity<20)
)