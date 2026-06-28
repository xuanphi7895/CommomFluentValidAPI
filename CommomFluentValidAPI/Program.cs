using CommonFluentValidAPI;
using CommonFluentValidAPI.StaticUtils;
using CommonFluentValidAPI.Helper;
using CommonFluentValidAPI.Enum;
using CommonFluentValidAPI.Reminder;
// See https://aka.ms/new-console-template for more information
//Console.ForegroundColor = ConsoleColor.White;
//Console.WriteLine("Toi xin chao ban!");


//DelegateCommonLogHelper.ShowTextToScreen showText = new DelegateCommonLogHelper.ShowTextToScreen(DelegateCommonLogHelper.Information);
//Console.WriteLine("Please enter your name");

//var name = Console.ReadLine();

//var isCheck = CommonFieldValidatorFunctions.LengthFieldValidDel(name, 10, 100);

//if (isCheck)
//{
//    showText("Name", name);
//}
//else
//{
//    showText = new DelegateCommonLogHelper.ShowTextToScreen(DelegateCommonLogHelper.Error);
//    showText.Invoke("Name", name);
//}

//LogTextToFile logFile = new LogTextToFile(LogFileHelper.AddTextToFileLog);

//logFile.Invoke(UtilConstants.PATH, name, DateTime.Now.ToString("yyyy-MM-dd"), "Phi");
////showText("Name",name);



//Console.ReadKey();

//var manager = new ReminderManager();

//Console.Write("Enter reminder message: ");
//string msg = Console.ReadLine();

//Console.Write("Enter reminder time (yyyy-MM-dd HH:mm:ss): ");
//DateTime time = DateTime.Parse(Console.ReadLine());

//manager.AddReminder(new Reminder
//{
//    Message = msg,
//    TriggerTime = time
//});

//Console.WriteLine("Reminder is active. Press Enter to exit...");
//Console.ReadLine();
int n = 5;

// Set the Frequency
int frequency = 1000;

// Set the Duration
int duration = 400;

// Play beep sound n times
for (int i = 1; i < n; i++)
    Console.Beep(frequency, duration); 
    
