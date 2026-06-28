
namespace CommonFluentValidAPI
{
    public static class DelegateCommonLogHelper
    {

        public delegate void ShowLog(string text);
        public delegate void ShowTextToScreen(string field, string text);

        static public void Information(string field, string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{field} cua ban vua nhap: {text}");
        }

        static public void Warning(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($" {text}");
        }

        static public void Error(string field, string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{field} cua ban vua nhap bi loi: {text}");
        }

    }
}
