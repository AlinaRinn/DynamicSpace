using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DynamicSpace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            Form1_Load(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            int i = 0;

            foreach (DriveInfo d in allDrives)
            {
                Label lbl1 = new Label();
                tableLayoutPanel1.Controls.Add(lbl1, 0, i);
                lbl1.Dock = DockStyle.Right;
                lbl1.Text = d.Name;

                if (d.IsReady == true)
                {
                    Label lbl2 = new Label();
                    tableLayoutPanel1.Controls.Add(lbl2, 1, i);
                    long tmp0 = (d.AvailableFreeSpace / 1024 / 1024);
                    lbl2.Dock = DockStyle.Right;
                    lbl2.Text = tmp0.ToString() + " MB";

                    tmp0 = 0;
                }
                i++;
            }
        }
    }
}
