namespace autoCheck
{
    partial class AutoCheckOn
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.handCkoff = new System.Windows.Forms.CheckBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUa = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.dtpCheckOff = new System.Windows.Forms.DateTimePicker();
            this.chkCheckOff = new System.Windows.Forms.CheckBox();
            this.dtpCheckOn = new System.Windows.Forms.DateTimePicker();
            this.chkCheckOn = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStartInterval = new System.Windows.Forms.Button();
            this.lblTimenow = new System.Windows.Forms.Label();
            this.txtTimeNow = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(967, 436);
            this.webBrowser1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 436);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtTimeNow);
            this.splitContainer1.Panel1.Controls.Add(this.lblTimenow);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.handCkoff);
            this.splitContainer1.Panel1.Controls.Add(this.btnCheckOut);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtPwd);
            this.splitContainer1.Panel1.Controls.Add(this.txtUa);
            this.splitContainer1.Panel1.Controls.Add(this.btnCheckIn);
            this.splitContainer1.Panel1.Controls.Add(this.dtpCheckOff);
            this.splitContainer1.Panel1.Controls.Add(this.chkCheckOff);
            this.splitContainer1.Panel1.Controls.Add(this.dtpCheckOn);
            this.splitContainer1.Panel1.Controls.Add(this.chkCheckOn);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnStartInterval);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(967, 534);
            this.splitContainer1.SplitterDistance = 94;
            this.splitContainer1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // handCkoff
            // 
            this.handCkoff.AutoSize = true;
            this.handCkoff.Location = new System.Drawing.Point(828, 75);
            this.handCkoff.Name = "handCkoff";
            this.handCkoff.Size = new System.Drawing.Size(96, 16);
            this.handCkoff.TabIndex = 12;
            this.handCkoff.Text = "开启手动签退";
            this.handCkoff.UseVisualStyleBackColor = true;
            this.handCkoff.CheckedChanged += new System.EventHandler(this.handCkoff_CheckedChanged);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(491, 29);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(98, 40);
            this.btnCheckOut.TabIndex = 11;
            this.btnCheckOut.Text = "手动签退";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(275, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Save_Logon";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(43, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "PWD";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "UserName";
            this.label1.Visible = false;
            // 
            // txtPwd
            // 
            this.txtPwd.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::autoCheck.Properties.Settings.Default, "pwd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPwd.Enabled = false;
            this.txtPwd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtPwd.Location = new System.Drawing.Point(77, 44);
            this.txtPwd.MaxLength = 20;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(162, 21);
            this.txtPwd.TabIndex = 7;
            this.txtPwd.Text = global::autoCheck.Properties.Settings.Default.pwd;
            this.txtPwd.Visible = false;
            // 
            // txtUa
            // 
            this.txtUa.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::autoCheck.Properties.Settings.Default, "ua", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtUa.Enabled = false;
            this.txtUa.Location = new System.Drawing.Point(77, 15);
            this.txtUa.MaxLength = 20;
            this.txtUa.Name = "txtUa";
            this.txtUa.Size = new System.Drawing.Size(162, 21);
            this.txtUa.TabIndex = 6;
            this.txtUa.Text = global::autoCheck.Properties.Settings.Default.ua;
            this.txtUa.Visible = false;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(365, 27);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(98, 40);
            this.btnCheckIn.TabIndex = 5;
            this.btnCheckIn.Text = "手动签到";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // dtpCheckOff
            // 
            this.dtpCheckOff.CustomFormat = "hh:mm";
            this.dtpCheckOff.Enabled = false;
            this.dtpCheckOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOff.Location = new System.Drawing.Point(697, 46);
            this.dtpCheckOff.Name = "dtpCheckOff";
            this.dtpCheckOff.ShowUpDown = true;
            this.dtpCheckOff.Size = new System.Drawing.Size(115, 21);
            this.dtpCheckOff.TabIndex = 4;
            this.dtpCheckOff.Value = new System.DateTime(2011, 10, 21, 18, 35, 0, 0);
            this.dtpCheckOff.Visible = false;
            // 
            // chkCheckOff
            // 
            this.chkCheckOff.AutoSize = true;
            this.chkCheckOff.Enabled = false;
            this.chkCheckOff.Location = new System.Drawing.Point(595, 46);
            this.chkCheckOff.Name = "chkCheckOff";
            this.chkCheckOff.Size = new System.Drawing.Size(96, 16);
            this.chkCheckOff.TabIndex = 3;
            this.chkCheckOff.Text = "定时自动签退";
            this.chkCheckOff.UseVisualStyleBackColor = true;
            this.chkCheckOff.Visible = false;
            this.chkCheckOff.CheckedChanged += new System.EventHandler(this.chkCheckOff_CheckedChanged);
            // 
            // dtpCheckOn
            // 
            this.dtpCheckOn.CustomFormat = "HH:mm";
            this.dtpCheckOn.Enabled = false;
            this.dtpCheckOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOn.Location = new System.Drawing.Point(697, 12);
            this.dtpCheckOn.Name = "dtpCheckOn";
            this.dtpCheckOn.ShowUpDown = true;
            this.dtpCheckOn.Size = new System.Drawing.Size(115, 21);
            this.dtpCheckOn.TabIndex = 2;
            this.dtpCheckOn.Value = new System.DateTime(2011, 10, 21, 9, 25, 0, 0);
            // 
            // chkCheckOn
            // 
            this.chkCheckOn.AutoSize = true;
            this.chkCheckOn.Location = new System.Drawing.Point(595, 12);
            this.chkCheckOn.Name = "chkCheckOn";
            this.chkCheckOn.Size = new System.Drawing.Size(96, 16);
            this.chkCheckOn.TabIndex = 1;
            this.chkCheckOn.Text = "定时自动签到";
            this.chkCheckOn.UseVisualStyleBackColor = true;
            this.chkCheckOn.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(847, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStartInterval
            // 
            this.btnStartInterval.Enabled = false;
            this.btnStartInterval.Location = new System.Drawing.Point(847, 12);
            this.btnStartInterval.Name = "btnStartInterval";
            this.btnStartInterval.Size = new System.Drawing.Size(75, 23);
            this.btnStartInterval.TabIndex = 0;
            this.btnStartInterval.Text = "开始计时";
            this.btnStartInterval.UseVisualStyleBackColor = true;
            this.btnStartInterval.Click += new System.EventHandler(this.btnStartInterval_Click);
            // 
            // lblTimenow
            // 
            this.lblTimenow.AutoSize = true;
            this.lblTimenow.Location = new System.Drawing.Point(13, 76);
            this.lblTimenow.Name = "lblTimenow";
            this.lblTimenow.Size = new System.Drawing.Size(41, 12);
            this.lblTimenow.TabIndex = 14;
            this.lblTimenow.Text = "label4";
            // 
            // txtTimeNow
            // 
            this.txtTimeNow.Location = new System.Drawing.Point(180, 66);
            this.txtTimeNow.Name = "txtTimeNow";
            this.txtTimeNow.Size = new System.Drawing.Size(420, 21);
            this.txtTimeNow.TabIndex = 15;
            // 
            // AutoCheckOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 534);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AutoCheckOn";
            this.Text = "AutoCheckOn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutoCheckOn_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dtpCheckOn;
        private System.Windows.Forms.CheckBox chkCheckOn;
        private System.Windows.Forms.Button btnStartInterval;
        private System.Windows.Forms.DateTimePicker dtpCheckOff;
        private System.Windows.Forms.CheckBox chkCheckOff;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtUa;
        public System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.CheckBox handCkoff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTimenow;
        private System.Windows.Forms.TextBox txtTimeNow;
    }
}

