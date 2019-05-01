using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        double Sqr(double d);
    }
}
