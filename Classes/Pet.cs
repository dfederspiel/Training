using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Pet
    {
        SpeechSynthesizer synth;
        static Random rnd = new Random();
        public string Name { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }
        public DateTime Born { get; set; }
        public string Breed { get; set; }

        string[] sounds = { "One", "Cat", "Works", "Food", "Beep" };

        public Pet()
        {
            synth = new SpeechSynthesizer();
            synth.Speak("I am alive.");
        }
        public void Speak()
        {
            synth.Speak(sounds[rnd.Next(sounds.Count())]);
        }

        public void Eat(float amount)
        {
            Weight += amount;
        }

        public void Poop(float amount)
        {
            Weight -= amount;
        }

        public void Die()
        {
            synth.Speak("Was this a good life?");
        }
    }
}
