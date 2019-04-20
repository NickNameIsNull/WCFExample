/************************************************** 解决方案相关说明 **************************************************/

1.VS使用但是2017编写的

2.在运行某些示例时，出现下列类似提示：
	System.ServiceModel.AddressAccessDeniedException
	  HResult=0x80131501
	  Message=HTTP 无法注册 URL http://+:500/。进程不具有此命名空间的访问权限(有关详细信息，请参见 http://go.microsoft.com/fwlink/?LinkId=70353)。
	  Source=System.ServiceModel
	  StackTrace:
	   在 System.ServiceModel.Channels.SharedHttpTransportManager.OnOpen()
	   在 System.ServiceModel.Channels.TransportManager.Open(TransportChannelListener channelListener)
	   在 System.ServiceModel.Channels.TransportManagerContainer.Open(SelectTransportManagersCallback selectTransportManagerCallback)
	   在 System.ServiceModel.Channels.TransportChannelListener.OnOpen(TimeSpan timeout)
	   在 System.ServiceModel.Channels.HttpChannelListener`1.OnOpen(TimeSpan timeout)
	   在 System.ServiceModel.Channels.CommunicationObject.Open(TimeSpan timeout)
	   在 System.ServiceModel.Dispatcher.ChannelDispatcher.OnOpen(TimeSpan timeout)
	   在 System.ServiceModel.Channels.CommunicationObject.Open(TimeSpan timeout)
	   在 System.ServiceModel.ServiceHostBase.OnOpen(TimeSpan timeout)
	   在 System.ServiceModel.Channels.CommunicationObject.Open(TimeSpan timeout)
	   在 System.ServiceModel.Channels.CommunicationObject.Open()
	   在 Example_1.Program.Main(String[] args) 在 E:\Codes\VsProjectDir\WCFExample\WCFExample\Chapter_1\Example_1\Program.cs 中: 第 34 行
	内部异常 1:
	HttpListenerException: 拒绝访问。
建议VS以管理员方式运行后，再指定的示例

3.解决方案中可能包含当前章节的多个示例。要运行指定的示例，在解决方案资源管理上找到指定的示例，右键，单击选择“设为启动项目”，再运行项目即可。
																							
/**************************************** 最后编写时间：2019年4月20日23:36:38 ****************************************/
