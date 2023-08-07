--1
select Dname,Dnum,MGRSSN as [id],Fname+''+Lname as [name]
from Departments D ,Employee E where D.MGRSSN=E.SSN

--2
select Dname,Pname from Departments D,Project P 
where  D.Dnum=P.Dnum

--3
select D.*,Fname+''+Lname as [name]
from Dependent D,Employee E 
where E.SSN=D.ESSN 

--4
select Pname,Pnumber,Plocation from Project
where city='cairo' or city='Alex'

--5
select * from Project where Pname like 'a%'

--6
select * from Employee where Dno=30 and (salary between 1000 and 2000)

--7 

select Fname+''+Lname as [name] from Employee e inner join Works_for w on e.SSN=w.ESSn inner join Project p
on p.Pnumber=w.Pno  and w.Hours >= 10 and p.Pname='AL Rabwah' and e.dno=10;

--8 
select e1.Fname+''+e1.Lname as [name] from Employee e1 ,Employee e2
where e2.SSN=e1.Superssn and e2.Fname='Kamel' and e2.Lname='Mohamed'

--9
select Fname+''+Lname as [name] ,Pname from Employee e,Project p,Works_for w
where e.SSN=w.ESSn and w.pno=p.Pnumber 
order by Pname 

--10
select Pnumber ,Dname,Lname,Address,Bdate from Project p, Departments d,Employee e
where p.City='cairo' and  d.Dnum=p.Dnum and d.MGRSSN=e.SSN

--11
select Fname+' '+Lname as [name] from Departments D ,Employee E where D.MGRSSN=E.SSN

--12
select e.*,Dependent_name from Employee e left outer join Dependent d on e.SSN=d.ESSN 

--13
insert into Employee values ('esraa','foda',102672,null,'cairo','F',3000,112233,30) 

--14 
insert into Employee values ('esraa','foda',102660,null,'cairo','F',null,null,30) 

--15
update Employee set Salary+=Salary*0.2 where SSN=102672;
