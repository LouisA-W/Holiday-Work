using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars
{
    class Program
    {
        class Car
        {
            private string Registration;
            private string Make;
            private string DateOfInspection;
            private int Mileage;
            public Car(string r, string m)
            {
                Registration = r;
                Make = m;
                Mileage = 0;
            }
            public string getMake() => Make;
            public int getMileage() => Mileage;
            public string getReg() => Registration;
            public string getDate() => DateOfInspection;
            void setInspectionDate(string date, int mileage)
            {
                date = getDate();
                mileage = getMileage();
            }
        }
        static void Main(string[] args)
        {

        }
    }
}