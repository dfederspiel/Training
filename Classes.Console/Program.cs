using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Console
{
    class Program
    {
        bool done = false;
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            bool running = true;

            while (running)
            {
                robot.Speak();
                robot.Speak("What would you like me to say?");
                var request = System.Console.ReadLine();
                if (request == "Die") running = false;
                else robot.Speak(request);
            }
            robot.Speak(10);
            robot.Die();
        }
    }
}
