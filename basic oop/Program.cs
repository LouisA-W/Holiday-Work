using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_oop
{
    class Program
    {
        static void feed(string state, int size)
        {
            size++;
            Console.WriteLine("Fish fed");
            if (size == 5)
            {
                state = "Fish";
            }
        }
        static void Main(string[] args)
        {
            Animal thisFish = new Animal("Fish", 1);
            Console.WriteLine("{0} is of size {1}", thisFish.getState(), thisFish.getSize());
            while(thisFish.getState() != "Fish")
            {
                thisFish.feed();
            }
            Console.WriteLine("It is now a big {0}", thisFish.getState());

            string thisFishState = "Fish";
            int thisFishSize = 1;
            Console.WriteLine("{0} is of size {1}", thisFishState, thisFishSize);
            while (thisFishState != "Fish")
            {
                feed(thisFishState, thisFishSize);
            }
            Console.WriteLine("It is now a big {0}", thisFishState);
        }
    }
    class Animal
    {
        private string state;
        private int size;
        public Animal(string s, int n)
        {
            state = s;
            size = n;
        }
        public void feed()
        {
            size++;
            state = "Fish";

        }
        public string getState() => state;
        public int getSize() => size;


    }
}