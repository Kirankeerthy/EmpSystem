// See https://aka.ms/new-console-template for more information


using TestDal;
using TestDbConsole;

Console.WriteLine("Hello, World!");
TestDbContext dbContext = new TestDbContext();

CrudEf<Parent>.Add("seema", true);


CrudEf<Parent>.Add("Master Varun", false);

CrudEf<Parent>.Add("Master Varun", false);
CrudEf<Parent>.Update("Master Varun", "Baby Barbie");
CrudEf<Parent>.Add("Imposter Hacker", false);
CrudEf<Parent>.Delete("Imposter Hacker");

var result= CrudEf<Parent>.SearchOne("Imposter Hacker");
Console.WriteLine($"Search matches : {result.Name}");



CrudEf<Parent>.Get()
.ForEach((p) =>
{
    if (p.IsActive == true)
        Console.WriteLine($"{p.Name} is an {p.IsActive} parents");
    else
        Console.WriteLine($"{p.Name} is child");
});






