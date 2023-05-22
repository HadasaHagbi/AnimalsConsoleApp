using ConsoleAppAnimalsHadasaHagbi.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimalsHadasaHagbi.Classes
{
    internal class Frog : Animal, Water, Land
    {
        private int NumberOfLegs { get; set; }
        private readonly string[] MOODS = { "make a purr, purr sound", "make a hiss sound" };

        public Frog(bool mammals, bool carnivorous, int mood) : base(mammals, carnivorous, mood)
        {

        }
        public override void sayHello(int mood)
        {
            string moodk = "";
            this.mood = mood;
            if (mood == 1)
            {
                moodk = "happy";
            }
            else
            {
                moodk = "scare";
            }
            Console.WriteLine("now i " + this.MOODS[mood - 1] + " because i " + moodk);
        }
        public int getNumberOfLegs()
        {
            return NumberOfLegs;
        }

        public bool hasGill()
        {
            return true;
        }

        public bool hasLaysEggs()
        {
            return true;
        }



    }
}
