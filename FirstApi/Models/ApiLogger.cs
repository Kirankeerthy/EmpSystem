namespace FirstApi.Models
{
   public  interface IApiLogger
    {
        void Log(string message);
    }
    public class ApiLogger : IApiLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now}:{message}");
        }
    }

    //level 03
    public class FileApiLogger : IApiLogger
    {
        private string _filename;
        public FileApiLogger()
        {

            _filename = $"Log_{DateTime.Now.ToFileTime()}.log";
            //environment.newline - gets into the new line
            File.WriteAllText(_filename,"This is a log file"+Environment.NewLine);

        }
        public void Log(string message)
        {
            File.AppendAllText(_filename,$"{DateTime.Now}:{message}");
            File.AppendAllText(_filename,Environment.NewLine);

           
        }
    }
}
