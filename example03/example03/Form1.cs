using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_seelctProcessFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "EXE File(*.exe)|*.exe|BAT File(*.bat)|*.bat";

            if( openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txt_processPath.Text = openFileDialog.FileName;

                // exe or bat 파일을 프로세스로 등록
                if( Path.GetExtension(openFileDialog.FileName) == ".exe")
                {
                    // 확장자 제거한 파일이름으로 프로세스 이름으로 등록               
                    this.txt_processName.Text = Path.GetFileNameWithoutExtension(openFileDialog.SafeFileName);
                }
            }
        }
    }
}
