// See https://aka.ms/new-console-template for more information


using EmpConsoled;
using EmpDal;
using EmpLib;

Person kiran = new Person();
kiran.Name = "kiran";
Console.WriteLine(kiran.Eat());

Person nick = new Person();
kiran.Name = "nick";
Console.WriteLine(nick.Eat());

Person john = new Employee() { Designation = "Intern", DOJ = DateTime.Now.AddMonths(-1) };


john.Name = "john";
((Employee)john).Designation = "analyst";
Console.WriteLine(john.Work());
Console.WriteLine($"EmpId for {john.Name} is {((Employee)john).EmpId}");
Console.WriteLine(((Employee)john).AttendTraining("C2C"));

//polymorphism
Father SharmajiFather = new Father();
Console.WriteLine($"sharmaji's Father :{SharmajiFather.Settle()}");
Console.WriteLine($"sharmaji's father get married:{SharmajiFather.Settle()}");
Console.WriteLine($"Sharmaji's father's concept of drawing (Using abstract): {SharmajiFather.Drawing()}");
Console.WriteLine($"Sharmaji's father's concept of drawing (Using abstract): {SharmajiFather.WhatIsDating()}");
Father Sharmaji = new Child();
Console.WriteLine($"sharmaji :{Sharmaji.Settle()}");
Console.WriteLine($"sharmaji get married :{Sharmaji.GetMarried()}");
Console.WriteLine($"Sharmaji's concept of drawing (using abstract): {Sharmaji.Drawing()}");
Console.WriteLine($"Sharmaji's concept of drawing (using abstract): {Sharmaji.WhatIsDating()}");





Father rose = new Child();
Console.WriteLine($"rose get married: {((Child)rose).GetMarried()}");

Employee jack = new Employee();
jack.Designation = "security system analyst";
Console.WriteLine(jack.Work());
Console.WriteLine(jack.Work("solving bugs"));

Employee charlie = new Employee();
charlie.setTaxInfo("i am eligible for the tax payer ");
Console.WriteLine(charlie.GetTaxInfo());

//Test calling one constructor from another
Person joe = new Person("7891A888RT321234","+91 9686750111");
//this constructor should call the constructor that sets the aadahr number

Console.WriteLine($"aadhar :{joe.Aadhar} | Mobile number : {joe.MobileNumber}");

Console.WriteLine($"Total Employee Count :{EmpUtils.EmpCount}");


EmpUtils.EmpDb.Add(jack);
EmpUtils.EmpDb.Add(charlie);
EmpUtils.EmpDb.Add(new Employee("AA78678767895678", "+91 8798675678") { Name="keerthi",Designation="analyst",Salary=700000});
EmpUtils.EmpDb.Add(new Employee("6713562765256356", "+91 8798675698") { Name = "nidha", Designation = "analyst", Salary = 90000 });
EmpUtils.EmpDb.Add(new Employee("6737365245625345", "+91 8798675610") { Name = "mahesh", Designation = "Sr. analyst", Salary = 70000 });
//get all employees whose aadhar card starts with aa
var resultlist= EmpUtils.EmpDb.Where((emp) =>  emp.Aadhar != null && emp.Aadhar.StartsWith("AA"));
resultlist.ToList().ForEach((emp) => Console.WriteLine($"{emp.Name} | {emp.Aadhar}"));


//select empName from employee where aadhar card LIKE="AA%";

var resultlist1 = EmpUtils.EmpDb.Where((emp) => emp.Salary > 600000);
resultlist1.ToList().ForEach((emp) => Console.WriteLine($"{emp.Name} | {emp.Salary}"));

EmpDbContext dbContext = new EmpDbContext();

crudemp<Employee>.insertemp("seema", true);
crudemp<Employee>.update("Master Varun", "Baby Barbie");

crudemp<Employee>.delete("Imposter Hacker");