namespace example02
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
            this.lbl_processPath = new System.Windows.Forms.Label();
            this.txt_processName = new System.Windows.Forms.TextBox();
            this.txt_processPath = new System.Windows.Forms.TextBox();
            this.btn_openDialogForSelectingProcessPath = new System.Windows.Forms.Button();
            this.btn_processInfo = new System.Windows.Forms.Button();
            this.lst_processInfo = new System.Windows.Forms.ListView();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_processName
            // 
            this.lbl_processName.AutoSize = true;
            this.lbl_processName.Location = new System.Drawing.Point(13, 13);
            this.lbl_processName.Name = "lbl_processName";
            this.lbl_processName.Size = new System.Drawing.Size(102, 15);
            this.lbl_processName.TabIndex = 0;
            this.lbl_processName.Text = "프로세스 이름";
            // 
            // lbl_processPath
            // 
            this.lbl_processPath.AutoSize = true;
            this.lbl_processPath.Location = new System.Drawing.Point(13, 46);
            this.lbl_processPath.Name = "lbl_processPath";
            this.lbl_processPath.Size = new System.Drawing.Size(102, 15);
            this.lbl_processPath.TabIndex = 1;
            this.lbl_processPath.Text = "프로세스 경로";
            // 
            // txt_processName
            // 
            this.txt_processName.Location = new System.Drawing.Point(117, 8);
            this.txt_processName.Name = "txt_processName";
            this.txt_processName.Size = new System.Drawing.Size(654, 25);
            this.txt_processName.TabIndex = 2;
            // 
            // txt_processPath
            // 
            this.txt_processPath.Location = new System.Drawing.Point(117, 40);
            this.txt_processPath.Name = "txt_processPath";
            this.txt_processPath.Size = new System.Drawing.Size(492, 25);
            this.txt_processPath.TabIndex = 3;
            // 
            // btn_openDialogForSelectingProcessPath
            // 
            this.btn_openDialogForSelectingProcessPath.Location = new System.Drawing.Point(615, 41);
            this.btn_openDialogForSelectingProcessPath.Name = "btn_openDialogForSelectingProcessPath";
            this.btn_openDialogForSelectingProcessPath.Size = new System.Drawing.Size(75, 24);
            this.btn_openDialogForSelectingProcessPath.TabIndex = 4;
            this.btn_openDialogForSelectingProcessPath.Text = "경로선택";
            this.btn_openDialogForSelectingProcessPath.UseVisualStyleBackColor = true;
            // 
            // btn_processInfo
            // 
            this.btn_processInfo.Location = new System.Drawing.Point(696, 41);
            this.btn_processInfo.Name = "btn_processInfo";
            this.btn_processInfo.Size = new System.Drawing.Size(75, 24);
            this.btn_processInfo.TabIndex = 5;
            this.btn_processInfo.Text = "등록";
            this.btn_processInfo.UseVisualStyleBackColor = true;
            // 
            // lst_processInfo
            // 
            this.lst_processInfo.Location = new System.Drawing.Point(16, 79);
            this.lst_processInfo.Name = "lst_processInfo";
            this.lst_processInfo.Size = new System.Drawing.Size(755, 296);
            this.lst_processInfo.TabIndex = 6;
            this.lst_processInfo.UseCompatibleStateImageBehavior = false;
            // 
            // txt_log
            // 
            this.txt_log.Location = new System.Drawing.Point(16, 382);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.Size = new System.Drawing.Size(755, 156);
            this.txt_log.TabIndex = 7;
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(696, 550);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 24);
            this.btn_stop.TabIndex = 9;
            this.btn_stop.Text = "제어정지";
            this.btn_stop.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(615, 550);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 24);
            this.btn_start.TabIndex = 8;
            this.btn_start.Text = "제어시작";
            this.btn_start.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 585);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.lst_processInfo);
            this.Controls.Add(this.btn_processInfo);
            this.Controls.Add(this.btn_openDialogForSelectingProcessPath);
            this.Controls.Add(this.txt_processPath);
            this.Controls.Add(this.txt_processName);
            this.Controls.Add(this.lbl_processPath);
            this.Controls.Add(this.lbl_processName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_processName;
        private System.Windows.Forms.Label lbl_processPath;
        private System.Windows.Forms.TextBox txt_processName;
        private System.Windows.Forms.TextBox txt_processPath;
        private System.Windows.Forms.Button btn_openDialogForSelectingProcessPath;
        private System.Windows.Forms.Button btn_processInfo;
        private System.Windows.Forms.ListView lst_processInfo;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_start;
    }
}

