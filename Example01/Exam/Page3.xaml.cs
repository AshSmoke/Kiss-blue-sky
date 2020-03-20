using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
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

namespace Example01.Exam
{
    /// <summary>
    /// Page3.xaml 的交互逻辑
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
            StringBuilder sb = new StringBuilder();
            IPGlobalProperties ipg = IPGlobalProperties.GetIPGlobalProperties();
            IPGlobalStatistics ipgs = ipg.GetIPv4GlobalStatistics();
            sb.AppendLine("本机注册域名" +ipg.DomainName);
            sb.AppendLine("接收数据包数" +ipgs.ReceivedPackets);
            sb.AppendLine("转发数据包数" +ipgs.ReceivedPacketsForwarded);
            sb.AppendLine("传送数据包数" +ipgs.ReceivedPacketsDelivered);
            sb.AppendLine("丢弃数据包数" +ipgs.ReceivedPacketsDiscarded);

            text1.Text = sb.ToString();
        }
    }
}
