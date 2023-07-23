select * from Employee
select Fname,Lname,salary,Dno from Employee
select Pname,Plocation,Dnum from project
select (Fname+' '+Lname) as [Full Name],Salary*12*10/100 as[Annual Comm] from Employee
select SSN,(Fname+' '+Lname) as [full Name] from Employee where (Salary>=1000)
select SSN,(Fname+' '+Lname) as [full Name] from Employee where (Salary*12>=10000)
select (Fname+' '+Lname) as [full Name],Salary  from Employee where Sex='F'
select Dname,Dnum from Departments where MGRSSN=968574
select Pname,Pnumber,Plocation from Project where Dnum=10