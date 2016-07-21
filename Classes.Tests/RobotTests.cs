using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;

namespace Classes.Tests
{
    [TestClass]
    public class RobotTests
    {
        [TestMethod]
        public void ConstructARobot()
        {
            Robot r = new Robot();
        }

        [TestMethod]
        public void KillARobot()
        {
            Robot r = new Robot();
            r.Die();
        }

        [TestMethod]
        public void RobotIntroducesItselfAndDies()
        {
            Robot r = new Robot();
            r.MakeIntroduction();
            r.Die();
        }

        [TestMethod]
        public void RobotUsesWords()
        {
            Robot r = new Robot();
            r.Speak(8);
            r.Die();
        }
    }
}
