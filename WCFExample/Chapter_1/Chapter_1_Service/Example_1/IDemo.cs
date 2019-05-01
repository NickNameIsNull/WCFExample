using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    /// <summary>
    /// 定义一个服务协定接口
    /// </summary>
    [ServiceContract]
    public interface IDemo
    {
        /// <summary>
        /// 定义一个操作协定Add
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [OperationContract]
        int Add(int a, int b);

        /// <summary>
        /// 未在方法上标记 OperationContract ；所以Run方法不会被是会操作协定公开
        /// </summary>
        void Run();
    }
}
