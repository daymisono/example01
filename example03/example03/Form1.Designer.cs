namespace example03
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_processName = new System.Windows.Forms.Label();
            this.lbl_processpath = new System.Windows.Forms.Label();
            this.txt_processName = new System.Windows.Forms.TextBox();
            this.txt_processPath = new System.Windows.Forms.TextBox();
            this.btn_registProcess = new System.Windows.Forms.Button();
            this.btn_seelctProcessFile = new System.Windows.Forms.Button();
            this.lst_processInfo = new System.Windows.Forms.ListView();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_processName
            // 
            this.lbl_processName.AutoSize = true;
            this.lbl_processName.Location = new System.Drawing.Point(13, 12);
            this.lbl_processName.Name = "lbl_processName";
            this.lbl_processName.Size = new System.Drawing.Size(102, 15);
            this.lbl_processName.TabIndex = 0;
            this.lbl_processName.Text = "프로세스 이름";
            // 
            // lbl_processpath
            // 
            this.lbl_processpath.AutoSize = true;
            this.lbl_processpath.Location = new System.Drawing.Point(13, 48);
            this.lbl_processpath.Name = "lbl_processpath";
            this.lbl_processpath.Size = new System.Drawing.Size(102, 15);
            this.lbl_processpath.TabIndex = 1;
            this.lbl_processpath.Text = "프로세스 경로";
            // 
            // txt_processName
            // 
            this.txt_processName.Location = new System.Drawing.Point(117, 8);
            this.txt_processName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_processName.Name = "txt_processName";
            this.txt_processName.Size = new System.Drawing.Size(733, 25);
            this.txt_processName.TabIndex = 2;
            // 
            // txt_processPath
            // 
            this.txt_processPath.Location = new System.Drawing.Point(117, 42);
            this.txt_processPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_processPath.Name = "txt_processPath";
            this.txt_processPath.Size = new System.Drawing.Size(571, 25);
            this.txt_processPath.TabIndex = 3;
            // 
            // btn_registProcess
            // 
            this.btn_registProcess.Location = new System.Drawing.Point(774, 42);
            this.btn_registProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_registProcess.Name = "btn_registProcess";
            this.btn_registProcess.Size = new System.Drawing.Size(75, 25);
            this.btn_registProcess.TabIndex = 4;
            this.btn_registProcess.Text = "등록하기";
            this.btn_registProcess.UseVisualStyleBackColor = true;
            this.btn_registProcess.Click += new System.EventHandler(this.btn_registProcess_Click);
            // 
            // btn_seelctProcessFile
            // 
            this.btn_seelctProcessFile.Location = new System.Drawing.Point(693, 42);
            this.btn_seelctProcessFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_seelctProcessFile.Name = "btn_seelctProcessFile";
            this.btn_seelctProcessFile.Size = new System.Drawing.Size(75, 25);
            this.btn_seelctProcessFile.TabIndex = 5;
            this.btn_seelctProcessFile.Text = "경로선택";
            this.btn_seelctProcessFile.UseVisualStyleBackColor = true;
            this.btn_seelctProcessFile.Click += new System.EventHandler(this.btn_seelctProcessFile_Click);
            // 
            // lst_processInfo
            // 
            this.lst_processInfo.Location = new System.Drawing.Point(16, 78);
            this.lst_processInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lst_processInfo.Name = "lst_processInfo";
            this.lst_processInfo.Size = new System.Drawing.Size(833, 353);
            this.lst_processInfo.TabIndex = 6;
            this.lst_processInfo.UseCompatibleStateImageBehavior = false;
            // 
            // txt_log
            // 
            this.txt_log.Location = new System.Drawing.Point(16, 438);
            this.txt_log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.Size = new System.Drawing.Size(833, 144);
            this.txt_log.TabIndex = 7;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(693, 592);
            this.btn_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 25);
            this.btn_start.TabIndex = 9;
            this.btn_start.Text = "제어시작";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(774, 592);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 25);
            this.btn_stop.TabIndex = 8;
            this.btn_stop.Text = "제어정지";
            this.btn_stop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 628);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.lst_processInfo);
            this.Controls.Add(this.btn_seelctProcessFile);
            this.Controls.Add(this.btn_registProcess);
            this.Controls.Add(this.txt_processPath);
            this.Controls.Add(this.txt_processName);
            this.Controls.Add(this.lbl_processpath);
            this.Controls.Add(this.lbl_processName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_processName;
        private System.Windows.Forms.Label lbl_processpath;
        private System.Windows.Forms.TextBox txt_processName;
        private System.Windows.Forms.TextBox txt_processPath;
        private System.Windows.Forms.Button btn_registProcess;
        private System.Windows.Forms.Button btn_seelctProcessFile;
        private System.Windows.Forms.ListView lst_processInfo;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
    }
}

