using Elon.Model;
using Elon.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elon.Controller
{
    /// <summary>
    /// Building the entire program here.
    /// </summary>
    internal class Build
    {

        public void StartBuild()
        {      
            while (true)
            {
                Console.Clear();
                GuiStart gui = new GuiStart();
                GetColor color = new GetColor();
                Car car = new Car(color.Color);
                while (car.BatteryCapacity.BatteryCapacity > 0)
                {
                    // If the car has more battery, the user can press any key to drive, if it doesnt have more battery left, the while loop will break.
                    Console.Clear();
                    gui.UserDrive();
                    car.Drive();
                    gui.Display(car);
                    Console.ReadKey();
                }
                gui.Charge();
                Console.ReadKey();
                car.Charge();
                gui.Display(car);
                gui.MakeNewCar();
                Console.ReadKey();
            }
        }
    }
}
