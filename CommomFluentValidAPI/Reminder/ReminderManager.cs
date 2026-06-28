using System.Timers;

namespace CommonFluentValidAPI.Reminder
{
    public class ReminderManager
    {
        private readonly List<Reminder> _reminders = new();
        private readonly System.Timers.Timer _timer;

        public ReminderManager()
        {
            _timer = new System.Timers.Timer(1000); // Check every second
            _timer.Elapsed += CheckReminders;
            _timer.Start();
        }

        public void AddReminder(Reminder reminder)
        {
            _reminders.Add(reminder);
            Console.WriteLine($"Reminder set for: {reminder.TriggerTime}");
        }

        private void CheckReminders(object sender, ElapsedEventArgs e)
        {
            var now = DateTime.Now;

            foreach (var reminder in _reminders)
            {
                if (!reminder.IsTriggered && reminder.TriggerTime <= now)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"🔔 Reminder: {reminder.Message} (at {now})");
                    Console.ResetColor();
                    reminder.IsTriggered = true;
                }
            }
        }
    }
}
