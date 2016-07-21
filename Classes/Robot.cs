using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Robot
    {
        SpeechSynthesizer synth;
        static Random rnd = new Random();

        public string Name { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }
        public DateTime BuildDate { get; set; }
        public DateTime Decomissioned { get; set; }
        public string Breed { get; set; }

        string[] sounds = { "Blip", "Bleep", "Bloop", "Beep" };
        string type = "Robot";

        public Robot()
        {
            synth = new SpeechSynthesizer();
            synth.Speak("I am alive.");
        }

        public void MakeIntroduction()
        {
            synth.Speak("I am a " + type);
        }

        public void Speak()
        {
            synth.Speak(sounds[rnd.Next(sounds.Count())]);
        }

        public void Speak(string words)
        {
            synth.Speak(words);
        }

        public void Speak(int numberOfWords)
        {
            string whatToSay = "";
            for(var x = 0; x < numberOfWords; x++)
            {
                whatToSay += " " + sounds[rnd.Next(sounds.Count())];
            }
            synth.Speak(whatToSay);
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
