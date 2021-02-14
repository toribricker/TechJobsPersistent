--Part 1
Jobs = Id(int), Name(String), EmployerId(int)
--Part 2
SELECT Name.Value FROM Employers WHERE Location = "St.Louis"
--Part 3
select s.Name,s.Description from skills as s
inner join jobskills as js
on s.Id = js.Skillid
order by s.Name
