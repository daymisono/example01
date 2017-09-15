using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if( open.ShowDialog()== DialogResult.OK)
            {
                this.processInfo.Text = open.FileName;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            this.txt_log.AppendText("프로세스 제어를 시작합니다.\n");
            String processName = this.processName.Text;

            Process[] localByName = Process.GetProcessesByName(processName);
            this.txt_log.AppendText("프로세스 이름 : " + processName + "\n");
            this.txt_log.AppendText("총 " + localByName.Length + " 개의 프로세스가 검출 되었습니다.\n");

            if(localByName.Length == 0)
            {
                this.txt_log.AppendText("실행중인 프로세스가 없으므로 " + this.processInfo.Text + "를 실행 합니다.");
            }

            Process.Start(this.processInfo.Text);
            if (localByName.Length == 0)
            {
                this.txt_log.AppendText(processName + " 프로세스가 실행되었습니다.\n");
            }

        }
    }
}
