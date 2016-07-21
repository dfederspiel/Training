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
            Robot p = new Robot();
            p.MakeIntroduction();

            bool running = true;
            while (running)
            {
                p.Speak("What would you like me to say?");
                var request = System.Console.ReadLine();
                if (request == "Die") running = false;
                else p.Speak(request);
            }
            p.Speak(10);
            p.Die();
        }
    }
}
