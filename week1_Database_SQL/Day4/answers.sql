--1
select Dependent_name,d.Sex from Dependent d,Employee e 
where d.Sex = 'F' and e.Sex='F'
union
select Dependent_name,d.Sex from Dependent d,Employee e 
where d.Sex='M' and e.Sex='M'

--2
select p.Pname,sum(w.Hours) as [Hours] from Project p,Works_for w
where p.Pnumber=w.pno
group by Pname

--3
select d.* from Departments d,employee e
where d.Dnum=e.Dno and e.SSN=(select min(SSN) from Employee)

--4
select d.Dname,min(e.Salary) as [Min_Salary],max(e.Salary)as [Max_Salary],AVG(e.Salary)as [Average_Salary] from Departments d,Employee e
where d.Dnum=e.Dno
group by Dname

--5
select  Fname+' '+Lname as Full_Name from Employee 
	where SSN in(select MGRSSN from Departments)
			and SSN not in (select ESSN from Dependent)

--6

select Dnum,Dname,avg(salary)
	from Departments inner join Employee
	on Dno=Dnum
	group by Dnum,Dname
	having avg(salary)<(select avg(salary) from Employee) 

--7
select Fname,Lname ,Pname from Employee inner join Works_for
	on SSN=Essn
	inner join Project
	on Pno=Pnumber
	order by Pno,Fname,Lname

--8
select
  (Select Max(Salary) from Employee) as maxsalary,
  (Select Max(Salary) from Employee
	where Salary not in (select max(Salary) from Employee )) as Second_max

--9
select Fname+' '+Lname as FullName from Employee
intersect
select Dependent_name from Dependent

--10
select Fname+' '+Lname as FullName,SSN from Employee
	where  EXISTS( select * from Dependent where SSN=ESSN)

--11
insert into Departments values('DEPT IT',100,112233,'1-11-2006')

--12
--a
update Departments
	set MGRSSN=968574
	where Dnum=100
--b
update Departments
	set MGRSSN=102672
	where Dnum=20
--c 
update Employee
	set Superssn=102672
	where SSN=102660

--13
update Employee
	set Superssn=102672
	where SSN in(select SSN from Employee where Superssn=223344)
update Dependent
	set ESSN=102672
	where ESSN=223344
update Departments
	set MGRSSN=102672
	where MGRSSN=223344
update Works_for
	set ESSn=102672
	where ESSn=223344
delete from Employee
	where SSN=223344

---14---

update Employee 
	set Salary=salary*0.3
	where SSN in (select ESSn from Works_for,Project where Pno=Pnumber and Pname='Al Rabwah')
