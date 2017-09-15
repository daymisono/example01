using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example03.BLO
{
    using System;
    using System.Threading;

    class ProcessController
    {
        private ListView lst_processInfo;
        private TextBox txt_log;

        public ProcessController(ListView lst_processInfo, TextBox txt_log)
        {
            this.lst_processInfo = lst_processInfo;
            this.txt_log = txt_log;
        }

        public void StartThread()
        {
            Thread th = new Thread(new ThreadStart(Execute));
            th.Start();
        }

        public void Execute()
        {
            txt_log.AppendText("들어왔다.\n");

            if (txt_log.InvokeRequired)
            {
             
            }
            else
            {
                txt_log.AppendText("들어왔다.\n");
            }
        } 

    }
}
