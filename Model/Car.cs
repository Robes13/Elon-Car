using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Elon.Model
{
    /// <summary>
    ///  This is the entire car, we cant construct the car without having the color first, and also we cant drive if the battery is 0.
    /// </summary>
    internal class Car
    {
        #region Fields
        private string _color;
        private Battery _batteryCapacity = new Battery();
        private short _metersDriven;
        #endregion Fields

        #region Constructors

        public Car(string color)
        {
            _color = color;
        }

        #endregion Constructors

        #region Properties

        public Battery BatteryCapacity 
        {
            get { return _batteryCapacity; } 
            set { _batteryCapacity = value; }
        }
        public short MetersDriven
        {
            get { return _metersDriven; }
            private set { _metersDriven = value; }
        }
        #endregion Properties

        public void Drive()
        {
            if (BatteryCapacity.BatteryCapacity > 0)
            {
                BatteryCapacity.BatteryCapacity -= 1;
                MetersDriven += 20;
            }
        }
        public void Charge()
        {
            BatteryCapacity.BatteryCapacity = 100;
            MetersDriven = 0;
        }

    }
}
