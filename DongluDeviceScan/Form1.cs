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
            skinTextBox4.Text = "";
        }

        public void initTreeNode()
        {
            skinTreeView1.Nodes.Clear();
            TreeNode dongluNode = new TreeNode("东陆设备(0个)");
            dongluNode.Tag = "东陆设备";
            TreeNode unKnowNode = new TreeNode("未知设备(0个)");
            unKnowNode.Tag = "未知设备";

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
                    td.Nodes.Add(new TreeNode(ip + "[" + mack_key + "]"));
                    td.Text = "未知设备(" + td.Nodes.Count + "个)";
                })));
            }
            else
            {
               
                BeginInvoke((new EventHandler(delegate (object o, EventArgs ea)
                {
                    TreeNode td = skinTreeView1.Nodes[0];
                    TreeNode findNodes = FindNodeByValue(td,deviceMac);
                    if (findNodes == null)
                    {
                        TreeNode node = new TreeNode(deviceMac);
                        node.Tag = deviceMac;
                        node.Nodes.Add(new TreeNode(ip + "[" + mack_key + "]"));
                        node.Text = node.Tag + "(" + node.Nodes.Count +"个设备)";
                        td.Nodes.Add(node);
                    }
                    else
                    {
                        findNodes.Nodes.Add(new TreeNode(ip + "[" + mack_key + "]"));
                        findNodes.Text = findNodes.Tag + "(" + findNodes.Nodes.Count + "个设备)";
                    }
                    int totalSize = getTreeNodeChildrenSize(td);
                    td.Text = td.Tag + "(" + totalSize + "个设备)";
                    skinTreeView1.ExpandAll();
                })));

            }
        }
        private TreeNode FindNodeByValue(TreeNode tnParent, string strValue)
        {
            if (tnParent == null) return null;
            if ((tnParent.Tag as string) == strValue) return tnParent;

            TreeNode tnRet = null;
            foreach (TreeNode tn in tnParent.Nodes)
            {
                tnRet = FindNodeByValue(tn, strValue);
                if (tnRet != null) break;
            }
            return tnRet;
        }

        public int getTreeNodeChildrenSize(TreeNode treeNode) {
            int i = 0;
            foreach (TreeNode tn in treeNode.Nodes) {
                if (tn.Nodes.Count == 0)
                {
                    i++;
                }
                else
                {
                    i = i + getTreeNodeChildrenSize(tn);
                }
            }
            return i;
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
            for (int i = 0; i < ipList.Count; i++) {
                if (i % 10 == 0) {
                    Thread.Sleep(500);
                }
                netUtil.checkIp(ipList.ElementAt(i), key, new System.Net.NetworkInformation.PingCompletedEventHandler(_myPing_PingCompleted));
            }
        }

        private void afterCheck(object sender, TreeViewEventArgs e)
        {
            TreeViewChecker.CheckControl(e);
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            if (skinTextBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("请选择升级文件", "提示");
                return;
            }

            if (skinTextBox3.Text.Trim().Length != 0)
            {
                if (netUtil.isAddressIp(skinTextBox3.Text.Trim()))
                {
                    tftpDownLoad(skinTextBox3.Text.Trim(), skinTextBox4.Text);
                    return;
                }
                else {
                    MessageBox.Show("设备ip输入有误", "提示");
                    return;
                }
                
            }

            List<TreeNode> treeNodeList = new List<TreeNode>();
            getAllTreeNodeCheck(skinTreeView1.Nodes, treeNodeList);
            foreach (TreeNode tn in treeNodeList)
            {
                Console.WriteLine("checked: " + tn.Checked + " check name:" + tn.Text);
                string deviceIp = tn.Text.Substring(0, tn.Text.IndexOf("["));
                tftpDownLoad(deviceIp, skinTextBox4.Text);
            }
        }

        public void getAllTreeNodeCheck(TreeNodeCollection treeNodes, List<TreeNode> nodeList) {
            foreach(TreeNode tn in treeNodes){
                if (tn.Nodes.Count == 0 && tn.Checked) {
                    nodeList.Add(tn);
                }
                if (tn.Nodes.Count != 0) {
                    getAllTreeNodeCheck(tn.Nodes, nodeList);
                }
            }
        }

        public void tftpDownLoad(string ip, string fileName)
        {
            if (!netUtil.checkIpConnect(ip)) {
                MessageBox.Show("升级设备:" + ip + "失败", "提示");
                return;
            }
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                skinProgressBar1.Maximum = (int)fs.Length;
                skinProgressBar1.Value = skinProgressBar1.Maximum / 4;
                Console.WriteLine("下载文件：" + fileName);
                Console.WriteLine("下载设备：" + ip);
                netUtil.iap(ip, 10001);
                skinProgressBar1.Value = skinProgressBar1.Maximum / 3;

                var client = new TftpClient(ip, 10001);

                var transfer = client.Upload(fileName);
                transfer.TransferMode = TftpTransferMode.octet;
                transfer.UserContext = ip;

                transfer.OnProgress += new TftpProgressHandler(transfer_OnProgress);
                transfer.OnFinished += new TftpEventHandler(transfer_OnFinshed);
                transfer.OnError += new TftpErrorHandler(transfer_OnError);
                

                transfer.Start(fs);

             
                TransferFinishedEvent.WaitOne();
                Thread.Sleep(5000);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        void transfer_OnProgress(ITftpTransfer transfer, TftpTransferProgress progress)
        {
            BeginInvoke((new EventHandler(delegate (object o, EventArgs e)
            {
                skinProgressBar1.Value = progress.TransferredBytes;
            })));
            TransferFinishedEvent.Set();
        }


        void transfer_OnError(ITftpTransfer transfer, TftpTransferError error)
        {
            Console.WriteLine("Transfer failed: " + error);
            MessageBox.Show("升级设备:" + transfer.UserContext + "失败", "提示");
            TransferFinishedEvent.Reset();
        }

        void transfer_OnFinshed(ITftpTransfer transfer)
        {
            Console.WriteLine("Transfer succeeded.");
            BeginInvoke((new EventHandler(delegate (object o, EventArgs e)
            {
                skinProgressBar1.Value = skinProgressBar1.Maximum;
            })));
            
            TransferFinishedEvent.Reset();
            MessageBox.Show("升级设备:"+transfer.UserContext+"成功", "提示");
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
