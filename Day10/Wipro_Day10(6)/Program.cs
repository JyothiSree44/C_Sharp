using System;
using System.Speech.Synthesis;

namespace Wipro_Day10_6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer speaker = new SpeechSynthesizer();

            speaker.Speak("Hello. Welcome to Wipro Day ten sound speech program.");

            Console.WriteLine("Speech completed.");
            Console.ReadLine();
        }
    }
}
