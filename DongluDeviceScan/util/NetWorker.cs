using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Net.Sockets;

namespace DongluDeviceScan
{
    class NetWorker
    {
        [DllImport("ws2_32.dll")]
        private static extern int inet_addr(string cp);
        [DllImport("IPHLPAPI.dll")]
        private static extern int SendARP(Int32 DestIP, Int32 SrcIP, ref Int64 pMacAddr, ref Int32 PhyAddrLen);

        private byte[] sendMessage = { 0x01, 0x57, 0x00, 0x01, 0x00, 0x01, 0x04, 0x02, 0x44, 0x4C, 0X32, 0X30, 0X31, 0X35, 0X30, 0X31, 0X32, 0X30, 0X03, 0X00 };

        public void iap(String ip, int port) {
            Console.WriteLine("进入iap 命令 " + ip + ":" + port);
            try
            {
                ///创建socket并连接到服务器
                Socket c = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                c.Connect(ip, port);
                c.Send(sendMessage);
                c.Close(2000);
            }
            catch (Exception e) {
                Console.WriteLine("iap 进入失败！");
                Console.WriteLine(e.Message);
            }
        }

        public void checkIp(string ip,string key, PingCompletedEventHandler asynEvent)
        {
            try
            {
                IPAddress address = IPAddress.Parse(ip);
                Ping ping = new Ping();
                ping.PingCompleted += asynEvent;
                ping.SendAsync(address, 1000, key);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public string getMacAddress(string IpAddress)
        {

            int start = System.DateTime.Now.Millisecond;
            string macAddress = "";
            Int32 ldest = 0;
            try
            {
                ldest = inet_addr(IpAddress);
            }
            catch (Exception iperr)
            {
                MessageBox.Show(iperr.Message);
            }
            Int64 macinfo = new Int64();
            Int32 len = 6;
            try
            {
                int res = SendARP(ldest, 0, ref macinfo, ref len);
            }
            catch (Exception err)
            {
                //    throw new Exception("在解析MAC地址过程发生了错误!"); 
                MessageBox.Show(err.Message);
            }
            string originalMACAddress = macinfo.ToString("X4");
            if (originalMACAddress != "0000" && originalMACAddress.Length == 12)
            { //合法MAC地址 
                string mac1, mac2, mac3, mac4, mac5, mac6;
                mac1 = originalMACAddress.Substring(10, 2);
                mac2 = originalMACAddress.Substring(8, 2);
                mac3 = originalMACAddress.Substring(6, 2);
                mac4 = originalMACAddress.Substring(4, 2);
                mac5 = originalMACAddress.Substring(2, 2);
                mac6 = originalMACAddress.Substring(0, 2);
                macAddress = mac1 + ":" + mac2 + ":" + mac3 + ":" + mac4 + ":" + mac5 + ":" + mac6;
                //canPing = true;
            }
            else
            {
                macAddress = "无法探测到MAC地址";
                //canPing = false;
            }
            Console.WriteLine("探测MAC地址耗时：" + (System.DateTime.Now.Millisecond - start));
            return macAddress;
        }

        public List<string> getAllScanIp(string startIp,string endIp) {
            Console.WriteLine("获取所有ip段：" + startIp + "--" + endIp);

            int start = System.DateTime.Now.Millisecond;
            int endPoint1 = startIp.LastIndexOf(".") + 1;
            int endPoint2 = endIp.LastIndexOf(".") + 1;

            string start1 = startIp.Substring(0, endPoint1);
            string start2 = endIp.Substring(0, endPoint2);
            if (!start1.Equals(start2)) {
                return new List<string>();
            }

            int end1 = Int32.Parse(startIp.Substring(endPoint1));
            int end2 = Int32.Parse(endIp.Substring(endPoint2));
            if (end1 > end2) {
                return new List<string>();
            }

            List<string> resultList = new List<string>();
            for (int i = end1; i < end2; i++) {
                resultList.Add(start1 + i);
            }
            Console.WriteLine("获取所有ip段耗时（毫秒）：" + (System.DateTime.Now.Millisecond - start));
            return resultList;
        }

        public string getLocalIp() {
            string hostName = Dns.GetHostName();
            IPAddress[] ipAddress = Dns.GetHostAddresses(hostName);
            return ipAddress.Select(e => e.ToString()).Where(e => e.Contains(".")).First();
        }

    }
}
