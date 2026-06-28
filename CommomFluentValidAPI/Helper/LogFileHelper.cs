using System.IO; 

namespace CommonFluentValidAPI.Helper
{
    public delegate void LogTextToFile(string path, string text, string datetime, string byuser);
    public static class LogFileHelper
    {

        public static void AddTextToFileLog(string path, string text, string datetime, string byuser)
        {
            string filename = $"{datetime}.txt";
            var time =  DateTime.Now.ToString();
            var docPath = Path.Combine(path, filename);
            var content = $"DateTime: {time}, Content: {text}, By user: {byuser} ";
            if (File.Exists(docPath))
            {
                using (StreamWriter w = File.AppendText(docPath))
                {
                    w.WriteLine(content);
                }

            } 
            else
            {
                // Create a file to write to.
                using (StreamWriter outputFile = new StreamWriter(docPath, true))
                {
                    outputFile.WriteLine(content);
                }
            }

        }
    }
}
