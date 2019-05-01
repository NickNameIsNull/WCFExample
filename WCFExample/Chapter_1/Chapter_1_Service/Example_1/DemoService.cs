using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    /// <summary>
    /// 定义一个类，实现服务协定：
    ///     服务器与客户端是通过协定来交互的；
    ///     实现服务协定的类不需要对外公开，它只在服务器内部使用，
    ///     因此该类不应该声明为public，可以定义为internal
    ///     由于Class默认的访问级别为internal，故当前类的internal是可以省略的
    /// </summary>
    internal class DemoService : IDemo
    {
        /// <summary>
        /// 对于服务协定中Add操作的实现方法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        public void Run()
        {
            //由于此方法在服务协定接口中未标记操作协定，故不会向客户端公开
            //此处不会添加任何实现代码
        }
    }
}
