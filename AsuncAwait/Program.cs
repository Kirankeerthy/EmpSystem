// See https://aka.ms/new-console-template for more information
//asynchronous programming

await SimpleTask();
File.WriteAllText(@"SomeFile.txt", "hello hi");


string contents= await ReadFile();
Console.WriteLine(contents);
async Task SimpleTask()
{
    Console.WriteLine("Starting of the task");
   await  Task.Delay(2000);//force a delay
    Console.WriteLine("Tak Complete");
}

async Task<string> ReadFile()
{
    using (StreamReader r = new StreamReader(@"SomeFile.txt"))
    { 
        return await r.ReadToEndAsync();
}
}
