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
    /// Page2.xaml 的交互逻辑
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            StringBuilder sb = new StringBuilder();
            
            NetworkInterface[] adpters = NetworkInterface.GetAllNetworkInterfaces();
            sb.AppendLine("适配器个数："+adpters.Length);
            int kase = 0;
            foreach(NetworkInterface adpter in adpters)
            {
                kase++;
                sb.AppendLine("-----------第" + kase + "个适配器信息------------");
                sb.AppendLine("描述信息：" + adpter.Description);
                sb.AppendLine("名称：" + adpter.Name);
                sb.AppendLine("速度：" + adpter.Speed / 1000 / 1000 + "M");
                byte[] macBytes = adpter.GetPhysicalAddress().GetAddressBytes();
                sb.AppendLine("MAC地址：" + BitConverter.ToString(macBytes));
                IPInterfaceProperties ipp = adpter.GetIPProperties();
                IPAddressCollection dnsservers = ipp.DnsAddresses;
                if (dnsservers.Count > 0)
                {
                    foreach(IPAddress dns in dnsservers)
                    {
                        sb.AppendLine("DNS服务器IP地址：" + dns);
                    }
                }
            }
            text1.Text = sb.ToString();
        }
    }
}
