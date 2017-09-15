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
using System.Diagnostics;

namespace example03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lst_processInfo.BeginUpdate();
            this.lst_processInfo.View = View.Details;
            this.lst_processInfo.Columns.Add("번호", 50, HorizontalAlignment.Left);
            this.lst_processInfo.Columns.Add("이름", 100, HorizontalAlignment.Left);
            this.lst_processInfo.Columns.Add("경로", 450, HorizontalAlignment.Left);
            this.lst_processInfo.Columns.Add("상태", 100, HorizontalAlignment.Left);
            this.lst_processInfo.EndUpdate();
        }

        private void btn_registProcess_Click(object sender, EventArgs e)
        {
            String processName = txt_processName.Text;
            String processPath = txt_processPath.Text;

            ListViewItem foundItem = this.lst_processInfo.FindItemWithText(processName);
            if (foundItem != null)
            {
                txt_log.AppendText(processName + " 프로세스가 중복 되었습니다.\n");
                return;
            }

            foundItem = this.lst_processInfo.FindItemWithText(processPath);
            if (foundItem != null)
            {
                txt_log.AppendText(processPath + " 프로세스 경로가 중복 되었습니다.\n");
                return;
            }

            ListViewItem lvi = new ListViewItem((this.lst_processInfo.Items.Count + 1).ToString());
            lvi.SubItems.Add(processName);
            lvi.SubItems.Add(processPath);
            
            if(Process.GetProcessesByName(processName).Length == 0)
            {
                lvi.SubItems.Add("정지상태");
            }
            else
            {
                lvi.SubItems.Add("동작 중");
            }

            this.lst_processInfo.Items.Add(lvi);

        }

        private void btn_seelctProcessFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "EXE File(*.exe)|*.exe|BAT File(*.bat)|*.bat";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txt_processPath.Text = openFileDialog.FileName;

                // exe or bat 파일을 프로세스로 등록
                if (Path.GetExtension(openFileDialog.FileName) == ".exe")
                {
                    // 확장자 제거한 파일이름으로 프로세스 이름으로 등록               
                    this.txt_processName.Text = Path.GetFileNameWithoutExtension(openFileDialog.SafeFileName);
                }
            }
        }

       
    }
}
