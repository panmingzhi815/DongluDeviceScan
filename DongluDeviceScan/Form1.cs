using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace DongluDeviceScan
{
    public partial class Form1 : CCWin.Skin_Color
    {

        private NetWorker netUtil = new NetWorker();
        
        public Form1()
        {
            InitializeComponent();
        }

        public void initTreeNode() {
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
            if (!e.UserState.Equals(skinProgressBar1.Name)) {
                return;
            }
            if (e.Reply.Status == IPStatus.Success)
            {
                string ip = e.Reply.Address.ToString();
                skinTreeView1.TopNode.Nodes.Add(new TreeNode(ip + "[" + netUtil.getMacAddress(ip) + "]"));
                skinTreeView1.TopNode.Text = "东陆设备(" + skinTreeView1.TopNode.Nodes.Count + "个)";
                Console.WriteLine("success : " + e.Reply.Address.ToString());
            }
            skinProgressBar1.Value = skinProgressBar1.Value + 1;
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            initTreeNode();
            netUtil.setScanIp(skinTextBox1.Text,skinTextBox2.Text);
            List<string> ipList = netUtil.getAllScanIp();

            string key = DateTime.Now.ToLongTimeString();
            skinProgressBar1.Name = key;
            skinProgressBar1.Maximum = ipList.Count();
            skinProgressBar1.Minimum = 0;
            skinProgressBar1.Value = 0;

            foreach (string s in ipList)
            {
                netUtil.checkIp(s, key, new System.Net.NetworkInformation.PingCompletedEventHandler(_myPing_PingCompleted));
            }
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {

        }

        private void afterCheck(object sender, TreeViewEventArgs e)
        {
            TreeViewChecker.CheckControl(e);
        }
    }
}
