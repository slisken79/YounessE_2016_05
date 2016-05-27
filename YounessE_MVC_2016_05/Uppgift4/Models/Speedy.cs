using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Uppgift4.Models
{
    public class Speedy
    {
        public double GetCurrentSpeed(double distanceC, double tid)
        {
            if (tid == 0)
                throw new DivideByZeroException();
            return distanceC / tid;
        }
    }
}