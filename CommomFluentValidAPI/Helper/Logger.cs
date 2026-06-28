using CommonFluentValidAPI.Enum;

namespace CommonFluentValidAPI.Helper
{
    public sealed class Logger
    {
        private static string _logFilePath = "App.log";

        private static readonly Lazy<Logger> _instance = new(() => new Logger(_logFilePath));

        private readonly StreamWriter _writer;

        private Logger(string path)
        {
            _writer = new StreamWriter(path, append: true)
            {
                AutoFlush = true
            };
        }
        public static Logger Instance => _instance.Value;

        /// <summary>
        /// Config path in here. Default equal App.log
        /// </summary>
        /// <param name="logFilePath"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public static void Configure(string logFilePath)
        {
            if (_instance.IsValueCreated)
            {
                throw new InvalidOperationException("Logger is already initialized.");
            }
            _logFilePath = logFilePath;
        }

        public void Log(string message, LogLevel level = LogLevel.INFO)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string formattedMessage = $"[{timestamp}] [{level}] {message}";

            // Log to file
            _writer.WriteLine(formattedMessage);

            // Log to console with color
            Console.ForegroundColor = GetColor(level);
            Console.WriteLine(formattedMessage);
            Console.ResetColor();

        }

        private ConsoleColor GetColor(LogLevel level)
        {
            return level switch
            {
                LogLevel.DEBUG => ConsoleColor.Gray,
                LogLevel.INFO => ConsoleColor.Green,
                LogLevel.WARN => ConsoleColor.Yellow,
                LogLevel.ERROR => ConsoleColor.Red,
                LogLevel.FATAL => ConsoleColor.Magenta,
                _ => ConsoleColor.White,
            };
        }

        public void Close()
        {
            _writer?.Close();
        }

    }
}
