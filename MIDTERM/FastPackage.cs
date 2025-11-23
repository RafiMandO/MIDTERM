using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM
{
     class FastPackage : Package
    {
        public FastPackage() : base() { }

        public FastPackage(string description, double weight, double distance)
            : base(description, weight, 120, distance)
        {
        }
    }
}
