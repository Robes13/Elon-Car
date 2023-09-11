using Elon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elon.View
{
    /// <summary>
    /// This class just draws everything that is needed.
    /// </summary>
    internal class GuiStart
    {
        #region Fields
        private string _start;
        #endregion Fields

        #region Constructers
        public GuiStart()
        { 
            _start = "Please enter the color of the car you want: ";
            Console.WriteLine(_start);
        }
        #endregion Constructers
        public void Display(Car car)
        {
            Console.WriteLine(car.BatteryCapacity.BatteryCapacity + "% left");
            Console.WriteLine(car.MetersDriven + " Meters Driven");
        }
        public void UserDrive()
        {
            Console.WriteLine("Press any key to drive");
        }
        public void Charge()
        {
            Console.WriteLine("Press any key to charge up your car.");
        }
        public void MakeNewCar()
        {
            Console.WriteLine("Press any key to make a new car.");
        }
    }
}
