using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elon.Model
{
    /// <summary>
    /// This class gets the color from the user.
    /// </summary>
    internal class GetColor
    {
        #region Fields
        private string color;
        #endregion Fields

        #region Constructors
        public GetColor()
        {
            color = Console.ReadLine();
        }
        #endregion Constructors

        #region Properties
        public string Color 
        { 
            get { return color; }
            set { color = value; }
        }
        #endregion Properties

    }
}
