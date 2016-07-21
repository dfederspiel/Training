using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Brobot : Robot
    {
        public Brobot()
        {
            Type = "Bro bot";
            Sounds = new string[] { "Balls", "Beers", "Boobs" };
        }
        public override void MakeIntroduction()
        {
            base.MakeIntroduction();
        }
    }
}
