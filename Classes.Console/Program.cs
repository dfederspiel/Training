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
        static void Main(string[] args)
        {
            

            Pet p = new Pet();
            var i = 0;
            while(i < 5)
            {
                p.Speak();
                i++;
            }
            p.Die();
        }
    }
}
