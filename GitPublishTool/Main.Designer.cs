namespace GitPublishTool
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProjectPath = new System.Windows.Forms.TextBox();
            this.lblProjectPath = new System.Windows.Forms.Label();
            this.lblCsprojPath = new System.Windows.Forms.Label();
            this.txtOutLog = new System.Windows.Forms.TextBox();
            this.lblOutLog = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.cbxCsprojPath = new System.Windows.Forms.ComboBox();
            this.btnPull = new System.Windows.Forms.Button();
            this.btnPublish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProjectPath
            // 
            this.txtProjectPath.Location = new System.Drawing.Point(110, 6);
            this.txtProjectPath.Name = "txtProjectPath";
            this.txtProjectPath.Size = new System.Drawing.Size(270, 21);
            this.txtProjectPath.TabIndex = 0;
            this.txtProjectPath.TextChanged += new System.EventHandler(this.txtProjectPath_TextChanged);
            // 
            // lblProjectPath
            // 
            this.lblProjectPath.AutoSize = true;
            this.lblProjectPath.Location = new System.Drawing.Point(12, 9);
            this.lblProjectPath.Name = "lblProjectPath";
            this.lblProjectPath.Size = new System.Drawing.Size(95, 12);
            this.lblProjectPath.TabIndex = 1;
            this.lblProjectPath.Text = "项目文件夹路径:";
            // 
            // lblCsprojPath
            // 
            this.lblCsprojPath.AutoSize = true;
            this.lblCsprojPath.Location = new System.Drawing.Point(24, 37);
            this.lblCsprojPath.Name = "lblCsprojPath";
            this.lblCsprojPath.Size = new System.Drawing.Size(83, 12);
            this.lblCsprojPath.TabIndex = 4;
            this.lblCsprojPath.Text = "工程文件路径:";
            // 
            // txtOutLog
            // 
            this.txtOutLog.Location = new System.Drawing.Point(14, 90);
            this.txtOutLog.Multiline = true;
            this.txtOutLog.Name = "txtOutLog";
            this.txtOutLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutLog.Size = new System.Drawing.Size(447, 221);
            this.txtOutLog.TabIndex = 5;
            // 
            // lblOutLog
            // 
            this.lblOutLog.AutoSize = true;
            this.lblOutLog.Location = new System.Drawing.Point(12, 66);
            this.lblOutLog.Name = "lblOutLog";
            this.lblOutLog.Size = new System.Drawing.Size(35, 12);
            this.lblOutLog.TabIndex = 6;
            this.lblOutLog.Text = "输出:";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(386, 61);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 7;
            this.btnClean.Text = "清除";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // cbxCsprojPath
            // 
            this.cbxCsprojPath.FormattingEnabled = true;
            this.cbxCsprojPath.Location = new System.Drawing.Point(110, 34);
            this.cbxCsprojPath.Name = "cbxCsprojPath";
            this.cbxCsprojPath.Size = new System.Drawing.Size(270, 20);
            this.cbxCsprojPath.TabIndex = 8;
            // 
            // btnPull
            // 
            this.btnPull.Location = new System.Drawing.Point(386, 4);
            this.btnPull.Name = "btnPull";
            this.btnPull.Size = new System.Drawing.Size(75, 23);
            this.btnPull.TabIndex = 9;
            this.btnPull.Text = "获取";
            this.btnPull.UseVisualStyleBackColor = true;
            this.btnPull.Click += new System.EventHandler(this.btnPull_Click);
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(386, 32);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(75, 23);
            this.btnPublish.TabIndex = 10;
            this.btnPublish.Text = "发布";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 323);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.btnPull);
            this.Controls.Add(this.cbxCsprojPath);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.lblOutLog);
            this.Controls.Add(this.txtOutLog);
            this.Controls.Add(this.lblCsprojPath);
            this.Controls.Add(this.lblProjectPath);
            this.Controls.Add(this.txtProjectPath);
            this.Name = "Main";
            this.Text = "Git 发布工具";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProjectPath;
        private System.Windows.Forms.Label lblProjectPath;
        private System.Windows.Forms.Label lblCsprojPath;
        private System.Windows.Forms.TextBox txtOutLog;
        private System.Windows.Forms.Label lblOutLog;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.ComboBox cbxCsprojPath;
        private System.Windows.Forms.Button btnPull;
        private System.Windows.Forms.Button btnPublish;
    }
}

