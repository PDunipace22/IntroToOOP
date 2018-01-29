using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {
        private string hairLength;
        private int height;
        private int runningSpeed;
        private double weight;
        private bool bathRoom = true;

        public String HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public Dog()
        {

        }
        public Dog(string hairLength, int height, int runningSpeed, double weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

        public void Potty()
        {
            if(bathRoom)
            {
                bathRoom = false;
            }
            Console.WriteLine("Has the dog gone potty? " + bathRoom);
        }
        public void Bark()
        {
            Console.WriteLine("\a");
        }
    }
}
