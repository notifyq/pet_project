namespace Logic.Logger
{
    public class FileLogger: ILogger
    {
        private string Path 
        { 
            get => System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();    
        }
        private string Filename 
        {
            get => $"log_{DateOnly.FromDateTime(DateTime.Now).ToString()}.txt";
        }
        public FileLogger() { }
        public void Log(string message)
        {
            using(System.IO.StreamWriter file = new System.IO.StreamWriter(Path + "\\" + Filename, true))
            {
                file.WriteLine(message);
            }
        }
    }
}
