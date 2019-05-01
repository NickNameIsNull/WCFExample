using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Example_2_Client
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_ClickAsync(object sender, RoutedEventArgs e)
        {
            Button btn = e.Source as Button;
            try
            {
                if (string.IsNullOrEmpty(txtInput.Text.Trim()))
                {
                    MessageBox.Show("您未输入数值，请输入一个Double类型的数值！", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtInput.Focus();
                    return;
                }
                double ind;
                try
                {
                    ind = double.Parse(txtInput.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("您输入的值类型不正确，请输入一个Double类型的数值！", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtInput.Focus();
                    return;
                }
                btn.IsEnabled = false;
                //实例化服务客户端
                WSSample.ServiceClient client = new WSSample.ServiceClient();
                //调用服务
                double retval = await client.SqrAsync(ind);
                //显示结果
                tbResult.Text = $"计算结果:{retval}";
                btn.IsEnabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("调用WCF服务进行计算出错：\r\n" + ex.Message, "错误", MessageBoxButton.OK, MessageBoxImage.Error);
                btn.IsEnabled = true;
            }
        }
    }
}
