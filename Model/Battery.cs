using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elon.Model
{
    /// <summary>
    /// This class contains the battery.
    /// </summary>
    internal class Battery
    {
        #region Fields
        private byte _batteryCapacity = 100;
        #endregion Fields

        #region Properties
        public byte BatteryCapacity 
        { 
            get { return _batteryCapacity; } 
            set { _batteryCapacity = value; } 
        }
        #endregion Properties
    }
}
