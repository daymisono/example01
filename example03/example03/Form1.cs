using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            this.lst_processInfo.BeginUpdate();
            this.lst_processInfo.View = View.Details;
            this.lst_processInfo.Columns.Add("이름", 100, HorizontalAlignment.Left);
            this.lst_processInfo.Columns.Add("경로", 450, HorizontalAlignment.Left);
            this.lst_processInfo.Columns.Add("상태", 100, HorizontalAlignment.Left);
        }

        private void btn_registProcess_Click(object sender, EventArgs e)
        {
            String processName = txt_processName.Text;
            String processPath = txt_processPath.Text;
        }
    }
}
