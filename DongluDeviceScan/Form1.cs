using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using Tftp.Net;
using System.Threading;
using System.IO;

namespace DongluDeviceScan
{
    public partial class Form1 : CCWin.Skin_Color
    {

        private NetWorker netUtil = new NetWorker();
        private static AutoResetEvent TransferFinishedEvent = new AutoResetEvent(false);
        private string key;
        private List<string> ipList;

        public Form1()
        {
            InitializeComponent();
            skinTextBox1.Text = "192.168.1.1";
            skinTextBox2.Text = "192.168.1.255";
            skinTextBox3.Text = "";
            skinTextBox4.Text = "";
        }

        public void initTreeNode()
        {
            skinTreeView1.Nodes.Clear();
            TreeNode dongluNode = new TreeNode("东陆设备(0个)");
            TreeNode unKnowNode = new TreeNode("未知设备(0个)");

            skinTreeView1.Nodes.Add(dongluNode);
            skinTreeView1.Nodes.Add(unKnowNode);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initTreeNode();

            this.Text += "本机ip[" + netUtil.getLocalIp() + "]";
        }

        private void _myPing_PingCompleted(object sender, PingCompletedEventArgs e)
        {
           
            Console.WriteLine("UserState:" + e.UserState);
            if (!e.UserState.Equals(skinProgressBar1.Name))
            {
                return;
            }
            BeginInvoke((new EventHandler(delegate (object o, EventArgs ea)
            {
                skinProgressBar1.Value = skinProgressBar1.Value + 1;
            })));
            if (e.Reply.Status == IPStatus.Success)
            {
                string ip = e.Reply.Address.ToString();
                Thread newthread = new Thread(new ParameterizedThreadStart(macThread));
                newthread.Start(ip);
            }

        }

        private void macThread(object obj)
        {
            string ip = obj as string;
            string mack_key = netUtil.getMacAddress(ip);
            String deviceMac = parseDeviceMac(mack_key.Substring(0, 5));
            if (deviceMac.Length == 0)
            {
                BeginInvoke((new EventHandler(delegate (object o, EventArgs ea)
                {
                    TreeNode td = skinTreeView1.Nodes[1];
                    td.Nodes.Add(new TreeNode(ip + "[" + netUtil.getMacAddress(ip) + "]"));
                    td.Text = "未知设备(" + td.Nodes.Count + "个)";
                })));
            }
            else
            {
                BeginInvoke((new EventHandler(delegate (object o, EventArgs ea)
                {
                    TreeNode td = skinTreeView1.Nodes[0];
                    td.Nodes.Add(new TreeNode(ip + "[" + netUtil.getMacAddress(ip) + "]" + deviceMac));
                    td.Text = "东陆设备(" + td.Nodes.Count + "个)";
                })));

            }
        }

        public string parseDeviceMac(string mac_key)
        {
            if (mac_key == null)
            {
                return "";
            }
            String mac_name;
            switch (mac_key)
            {
                case "B4:AA":
                    mac_name = "单门控制器";
                    break;
                case "B4:BB":
                    mac_name = "双门单项控制器";
                    break;
                case "B4:CC":
                    mac_name = "双门双向控制器";
                    break;
                case "B4:DD":
                    mac_name = "四门控制器";
                    break;
                case "B4:EE":
                    mac_name = "窗口扣费POS机";
                    break;
                case "B4:FF":
                    mac_name = "小票扣费POS机";
                    break;
                case "B4:11":
                    mac_name = "IC卡电梯控制器";
                    break;
                case "B4:22":
                    mac_name = "闸机门禁控制器";
                    break;
                case "B4:33":
                    mac_name = "停车场4000";
                    break;
                case "B4:44":
                    mac_name = "停车场2000";
                    break;
                case "B4:55":
                    mac_name = "双层票箱";
                    break;
                default:
                    mac_name = "";
                    break;
            }
            return mac_name;
        }


        private void skinButton1_Click(object sender, EventArgs e)
        {
            initTreeNode();
            this.ipList = netUtil.getAllScanIp(skinTextBox1.Text, skinTextBox2.Text);

            this.key = DateTime.Now.ToLongTimeString();
            skinProgressBar1.Name = key;
            skinProgressBar1.Maximum = ipList.Count();
            skinProgressBar1.Minimum = 0;
            skinProgressBar1.Value = 0;

            Thread newthread = new Thread(new ThreadStart(macThread));
            newthread.Start();
            int start = System.DateTime.Now.Millisecond;
           
        }

        private void macThread()
        {
            foreach (string s in ipList)
            {
                Console.WriteLine("key:" + key + "  s:" + s);
                netUtil.checkIp(s, key, new System.Net.NetworkInformation.PingCompletedEventHandler(_myPing_PingCompleted));
            }

        }

        private void afterCheck(object sender, TreeViewEventArgs e)
        {
            TreeViewChecker.CheckControl(e);
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            if (skinTextBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("请选中一个设备", "提示");
                return;
            }
            if (skinTextBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("请选择升级文件", "提示");
                return;
            }
            tftpDownLoad(skinTextBox3.Text, skinTextBox4.Text);
        }

        public void tftpDownLoad(string ip, string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            skinProgressBar1.Maximum = (int)fs.Length;
            skinProgressBar1.Value = skinProgressBar1.Maximum / 4;
            Console.WriteLine("下载文件：" + fileName);
            Console.WriteLine("下载设备：" + ip);
            netUtil.iap(ip, 10001);
            skinProgressBar1.Value = skinProgressBar1.Maximum / 2;

            var client = new TftpClient(ip, 10001);

            var transfer = client.Upload(fileName);
            transfer.TransferMode = TftpTransferMode.octet;

            transfer.OnProgress += new TftpProgressHandler(transfer_OnProgress);
            transfer.OnFinished += new TftpEventHandler(transfer_OnFinshed);
            transfer.OnError += new TftpErrorHandler(transfer_OnError);

            transfer.Start(fs);

            TransferFinishedEvent.WaitOne();
        }

        void transfer_OnProgress(ITftpTransfer transfer, TftpTransferProgress progress)
        {
            BeginInvoke((new EventHandler(delegate (object o, EventArgs e)
            {
                skinProgressBar1.Value = progress.TransferredBytes;
            })));
        }


        void transfer_OnError(ITftpTransfer transfer, TftpTransferError error)
        {
            Console.WriteLine("Transfer failed: " + error);
            TransferFinishedEvent.Set();
            MessageBox.Show("升级失败", "提示");
        }

        void transfer_OnFinshed(ITftpTransfer transfer)
        {
            Console.WriteLine("Transfer succeeded.");
            TransferFinishedEvent.Set();
            MessageBox.Show("升级成功", "提示");
        }

        private void skinTreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                string nodeText = e.Node.Text;
                skinTextBox3.Text = nodeText.Substring(0, nodeText.IndexOf("["));
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "bin文件(*.bin)|*.*";
            openFileDialog1.FileName = "";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.EndsWith(".bin"))
            {
                skinTextBox4.Text = openFileDialog1.FileName; 
            }
        }
    }
}
