using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaidTravelAgencyManagmentSystem
{
    internal class ITax1
    {
        public double mcTax_Rate = 0.075;
        public double iFindTax(double iCAmount)
        {
            double FindTax = iCAmount - (iCAmount * mcTax_Rate);
            return FindTax;
        }
    }
}
