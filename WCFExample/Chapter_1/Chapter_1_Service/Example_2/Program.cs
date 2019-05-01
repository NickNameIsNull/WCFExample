using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateServiceHostInstance();
        }

        /// <summary>
        /// 创建ServiceHost实例,寄宿WCF服务
        /// </summary>
        static void CreateServiceHostInstance()
        {
            //基址
            Uri baseAddress = new Uri("http://localhost:500");

            using (ServiceHost host = new ServiceHost(typeof(MyService), baseAddress))
            {
                //公开服务的元数据
                ServiceMetadataBehavior metadata = host.Description.Behaviors.Find<ServiceMetadataBehavior>();
                if (metadata == null)
                {
                    metadata = new ServiceMetadataBehavior();
                }

                metadata.HttpGetEnabled = true;//发布数据源数据以便使用Http/Get请求进行检索
                host.Description.Behaviors.Add(metadata);

                                //打开服务
                host.Open();
                Console.WriteLine("WCF 服务已启动");

                Console.WriteLine("输入任意键关闭程序....");
                Console.Read();

                //关闭服务
                host.Close();
            }
        }
    }
}
