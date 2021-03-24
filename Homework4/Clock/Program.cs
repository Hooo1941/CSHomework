using System;
using System.Timers;

namespace Clock
{
    internal class Program
    {
        private static int[] alarm;

        private static void Main()
        {
            Console.WriteLine("Input Alarm Time(format:HH:MM:SS):");
            var line = Console.ReadLine()?.Trim().Split(':');
            try
            {
                alarm = Array.ConvertAll(line ?? Array.Empty<string>(), int.Parse);
                if (alarm.Length != 3) throw new ArgumentException("Too few arguments!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid input!\n{e}");
                return;
            }

            var t = new Timer {Interval = 1000};
            t.Elapsed += Tick;
            t.Start();
            Console.ReadKey();
        }

        private static void Tick(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine($"Time: {e.SignalTime}");
            if (e.SignalTime.Hour == alarm[0] && e.SignalTime.Minute == alarm[1] && e.SignalTime.Second == alarm[2])
                Console.WriteLine("Alarm!");
        }
    }
}