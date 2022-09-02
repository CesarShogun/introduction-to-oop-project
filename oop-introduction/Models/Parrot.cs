using System;

namespace Exercise2.Models
{
    public class Parrot : Bird
    {
        public Parrot(string name, string color) : base(name, color)
        {
        }

        public override void Speak()
        {
            Console.WriteLine("Bwaaark! Why was the scarecrow promoted, bwaark? He was outstanding in his field, bwaaark!");
        }
    }
}
