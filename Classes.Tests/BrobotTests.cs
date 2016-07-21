using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Tests
{
    [TestClass]
    public class BrobotTests
    {
        [TestMethod]
        public void MakeBrobot()
        {
            Brobot b = new Brobot();
            b.MakeIntroduction();
            b.Speak(5);
        }
    }
}
