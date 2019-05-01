using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    class MyService : IService
    {
        public double Sqr(double d)
        {
            return d * d;
        }
    }
}
