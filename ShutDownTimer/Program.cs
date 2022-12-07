using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutDownTimer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the time to shut down
            Console.WriteLine("Enter the time to shut down (hh:mm:ss): (19:20:55)");
            string time = Console.ReadLine();
            // Convert time to DateTime
            DateTime timeToShutDown = DateTime.Parse(time);
            // Get the current time
            DateTime currentTime = DateTime.Now;
            // Calculate the time to wait
            TimeSpan timeToWait = timeToShutDown - currentTime;
            // Wait for the time to wait
            System.Threading.Thread.Sleep(timeToWait);
            // Shut down the computer
            System.Diagnostics.Process.Start("shutdown", "-s -t 0");
        }
    }
}
