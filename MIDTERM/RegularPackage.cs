using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM
{
     class RegularPackage : Package
    {
        public RegularPackage() : base() { }

        public RegularPackage(string description, double weight, double distance)
            : base(description, weight, 80, distance)
        {
        }
    }
}
