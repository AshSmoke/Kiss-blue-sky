using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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

namespace Example01.Exam
{
    /// <summary>
    /// Page1.xaml 的交互逻辑
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("获取www.cctv.com的所有IP地址");
            try
            {
                IPAddress[] ips = Dns.GetHostAddresses("www.cctv.com");
                foreach (IPAddress ip in ips)
                {
                    sb.AppendLine(ip.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "获取失败");
            }

            string s1 = Dns.GetHostName();
            IPHostEntry me = Dns.GetHostEntry(s1);
            sb.AppendLine("本机IP地址");
            foreach(IPAddress ip in me.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    sb.AppendLine("IPv4: "+ip.ToString());
                }
                else if (ip.AddressFamily == AddressFamily.InterNetworkV6)
                {
                    sb.AppendLine("IPv6: " + ip.ToString());
                }
                else
                {
                    sb.AppendLine("其他: " + ip.ToString());
                }
            }
            sb.AppendLine("IPv4和IPv6的环回地址");
            IPAddress ip1 = IPAddress.Parse("::1");
            IPAddress ip2 = IPAddress.Parse("127.0.0.1");
            IPEndPoint iep1 = new IPEndPoint(ip1, 80);
            IPEndPoint iep2 = new IPEndPoint(ip2, 80);
            if (iep1.AddressFamily == AddressFamily.InterNetwork)
            {
                sb.Append("IPv4端点：" + iep1.ToString());
            }
            else if (iep1.AddressFamily == AddressFamily.InterNetworkV6)
            {
                sb.Append("IPv6端点：" + iep1.ToString());
            }
            sb.AppendLine("端口：" + iep1.Port + "地址：" + iep1.Address + "地址组：" + iep1.AddressFamily);
            if (iep2.AddressFamily == AddressFamily.InterNetwork)
            {
                sb.Append("IPv4端点：" + iep2.ToString());
            }
            else if (iep2.AddressFamily == AddressFamily.InterNetworkV6)
            {
                sb.Append("IPv6端点：" + iep2.ToString());
            }
            sb.AppendLine("端口：" + iep2.Port + "地址：" + iep2.Address + "地址组：" + iep2.AddressFamily);
            text1.Text = sb.ToString();
        }
    }
}
