using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Management;
using System.Configuration.Assemblies;


namespace autoCheck
{
    public partial class AutoCheckOn : Form
    {
        bool IsTyped = false;
        bool IsLoaded = false;

        bool IsFnEnabled = false;

        bool IsCheckOn = false;
        bool IsCheckOff = false;

        HtmlDocument frmHrCheck = null;

        public static string userName = string.Empty;
        public static string pwd = string.Empty;

        public static int checkInterval = 1000;

        public static string targetUrl = string.Empty;

        public static bool autocheck = false;

        System.Timers.Timer timer = new System.Timers.Timer();

        System.Timers.Timer tmLogon = new System.Timers.Timer();

        HtmlDocument ifm ;//= webBrowser1.Document.Window.Frames["main"].Document;
        HtmlElement ctrUserName;// = ifm.GetElementById("username");
        HtmlElement ctrPwd;// = ifm.GetElementById("password");

        int reInitTimes = 0;

        public AutoCheckOn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitControls();

            InitHome();

            if (autocheck)
            {
                InitAutocheck();
            }
        }

        private void InitControls()
        {
            userName = ConfigurationManager.AppSettings["ua"].ToString();
            pwd = ConfigurationManager.AppSettings["pwd"].ToString();
            targetUrl = ConfigurationManager.AppSettings["target"].ToString();
            autocheck = bool.Parse(ConfigurationManager.AppSettings["autocheck"].ToString());

            btnCheckIn.Enabled = false;
            btnCheckOut.Enabled = false;
            webBrowser1.IsAccessible = true;
            webBrowser1.Select();
            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);

            timer.Enabled = false;

            timer.Interval = 500;

            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);

            tmLogon.Enabled = false;
            tmLogon.Stop();
            tmLogon.Interval = 1200;
            tmLogon.Elapsed += new System.Timers.ElapsedEventHandler(tmLogon_Elapsed);
        }

        void tmLogon_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //登陆延时操作
            InitAndLogOn();
        }

        void InitAutocheck()
        {
            dtpCheckOn.Enabled = true;
            dtpCheckOn.Checked = true;
            btnStartInterval.Enabled = true;
            btnStartInterval.PerformClick();
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            string varnow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            txtTimeNow.Text = varnow;
            Application.DoEvents();
            string setCheckOnTime = dtpCheckOn.Text;
            // string setCheckOffTime = dtpCheckOff.Text;
            string todayDate = DateTime.Now.ToString("yyyy-MM-dd");

            if (IsFnEnabled)
            {
              //  timer.Enabled = false;

                DateTime dtOn = DateTime.Parse(todayDate + " " + setCheckOnTime+":00");
               // DateTime dtOff = DateTime.Parse(todayDate + " " + setCheckOffTime);

                DateTime dtNow = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm"));

                //if (!IsCheckOn && IsCheckOff)
                //{
                    if (dtNow == dtOn)
                    {
                        timer.Stop();
                        //TODO: checkon
                        DoCheckOn();
                        timer.Start();
                    }
                //}

                //if (IsCheckOn && !IsCheckOff)
                //{
                //    if (dtNow == dtOff)
                //    {
                //        //TODO: checkoff

                //    }
                //}
            }
            else
            {
                timer.Enabled = false;
                DateTime dtOn = DateTime.Parse(todayDate + " " + setCheckOnTime);
                DateTime dtnow = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                DateTime dtSet = dtOn.AddMinutes(-10);
                if (dtnow == dtSet)
                {
                    InitHome();
                }
                timer.Enabled = true;
            }

  
                //DateTime dtOns = DateTime.Parse(todayDate + " " + setCheckOnTime + ":00");
                //DateTime dtnow = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                //DateTime dtSet = dtOns.AddMinutes(-10);
                //DateTime dtOnt = dtOns.AddMinutes(-9);
                //if ((dtnow >= dtSet) && reInitTimes < 1)
                //{
                //    //timer.Stop();
                //    reInitTimes++;
                //    InitHome();
                //    //timer.Start();
                //}


        }

        private void InitHome()
        {
            IsTyped = false;
            IsLoaded = false;

            IsFnEnabled = false;

            IsCheckOn = false;
            IsCheckOff = false;

            frmHrCheck = null;
            webBrowser1.Stop();
           // webBrowser1 = new WebBrowser();
            webBrowser1.Navigate(targetUrl);
        }

        private void AutoLogon()
        {
            string filter = targetUrl.Replace("http://", "").Replace("/", "");//"gate.ourgame.com"
            if (webBrowser1.Url.ToString().Contains(filter))
            {
                if (!IsTyped)
                {
                     ifm= webBrowser1.Document.Window.Frames["main"].Document;
                     ctrUserName = ifm.GetElementById("username");
                     ctrPwd = ifm.GetElementById("password");

                     InitAndLogOn();


                    //启动延时登陆
                    tmLogon.Start();
                    
                    //InputAndLogOn();
                    countX = 0;
                    IsTyped = true;
                }
                else
                {
                    if (!IsLoaded)
                    {
                        try
                        {
                            HtmlDocument ifmcheck = webBrowser1.Document.Window.Frames["main"].Frames["Body"].Frames["Nav"].Frames["hr_check"].Document;

                            frmHrCheck = ifmcheck;
                            foreach (HtmlElement el in ifmcheck.Forms[0].All)
                            {
                                //el.Name = "action";// name="action"
                                if (el.GetAttribute("value").ToLower() == "docheckon")
                                {
                                    IsCheckOff = true;
                                    IsCheckOn = false;
                                    IsFnEnabled = true;
                                    btnCheckIn.Enabled = true;
                                }
                                if (el.GetAttribute("value").ToLower() == "docheckoff")
                                {
                                    IsCheckOff = false;
                                    IsCheckOn = true;
                                    if (DateTime.Now >= DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd") + " 18:31:00"))
                                    {
                                        btnCheckOut.Enabled = true;
                                    }
                                }
                            }
                            IsLoaded = true;
                            label3.Text = "count:" + count.ToString() + "||countX:" + countX.ToString();
                        }
                        catch { }
                    }
                }
            }
        }

        private void InitAndLogOn()
        {
            tmLogon.Stop();
            if (ctrUserName != null)
            {
                // ctrUserName.SetAttribute("value", string.Empty);
                // System.Threading.Thread.Sleep(300);
                ctrUserName.Focus();
                SendKeys.Send(userName);
                // SendKeys.Send("{tab}");
                System.Threading.Thread.Sleep(300);
                Application.DoEvents();
                ctrPwd.Focus();
                Application.DoEvents();
                SendKeys.Send(pwd);
                Application.DoEvents();
                System.Threading.Thread.Sleep(300);
                webBrowser1.Update();
                Application.DoEvents();
                System.Threading.Thread.Sleep(300);
                SendKeys.Send("{enter}");
                //string tmp = "";
                // tmp = ifm.GetElementById("password").GetAttribute("value");
                // MessageBox.Show(tmp);                
            }
        }

        int count = 0;
        int countX = 0;
        void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            count++;
            //加载完成,登陆
            if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
            {
                countX++;
                label3.Text = countX.ToString();
                Application.DoEvents();
                AutoLogon();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            dtpCheckOn.Enabled = chkCheckOn.Checked;
            btnStartInterval.Enabled = chkCheckOn.Checked;
        }

       

        private void DoCheckOn()
        {
            frmHrCheck.InvokeScript("checkon");
          //  webBrowser1.Document.InvokeScript("checkon");
            // change checkon state
            IsCheckOn = true;
            IsCheckOff = false;
            refreshPage();
        }

        private void DoCheckOff()
        {
            // change checkoff state
            frmHrCheck.InvokeScript("checkoff");
            //webBrowser1.Document.InvokeScript("checkoff");
            IsCheckOff = true;
            IsCheckOn = false;
            refreshPage();
        }

        private void chkCheckOff_CheckedChanged(object sender, EventArgs e)
        {
            dtpCheckOff.Enabled = chkCheckOff.Checked;

        }

        private void btnStartInterval_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(dtpCheckOn.Text);
            if (timer.Enabled)
            {
                //timer.Enabled = false;
                timer.Stop();
               // timer.Enabled = false;
                AppConfigHelper.ModifyAppSeeting("autocheck", "false");
                btnStartInterval.Text = "开始计时";
            }
            else
            {
                btnStartInterval.Text = "停止计时";
                AppConfigHelper.ModifyAppSeeting("autocheck", "true ");
                timer.Start();
             //   timer.Enabled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HtmlDocument ifmcheck = webBrowser1.Document.Window.Frames["main"].Frames["Body"].Frames["Nav"].Frames["hr_check"].Document;
                foreach (HtmlElement el in ifmcheck.Forms[0].All)
                {
                    //el.Name = "action";// name="action"
                    if (el.GetAttribute("value").ToLower() == "docheckon")
                    {
                        IsCheckOff = true;
                        IsCheckOn = false;
                        IsFnEnabled = true;
                    }
                    if (el.GetAttribute("value").ToLower() == "docheckoff")
                    {
                        IsCheckOff = false;
                        IsCheckOn = true;
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            DoCheckOn();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            userName = txtUa.Text.Trim();
            pwd = txtPwd.Text.Trim();
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("输入用户名密码先!");
                txtUa.Focus();
            }
            else
            {
                webBrowser1.IsAccessible = true;
                webBrowser1.Select();
                InitHome();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoCheckOff();
        }

        private void refreshPage()
        {
          //  webBrowser1.Refresh();
            reInitTimes = 0;
            webBrowser1.Update();

        }

        private void handCkoff_CheckedChanged(object sender, EventArgs e)
        {
            if (handCkoff.Checked)
            {
                DialogResult dr = MessageBox.Show("确认开启手动签退？（开启后请勿在18:30前点击“手动签退”按钮，否则你就是个巨大的杯具！！！）", "兄弟,注意了!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    btnCheckOut.Enabled = true;
                }
                else
                {
                    handCkoff.Checked = false;
                    btnCheckOut.Enabled = false;
                }
            }
            else
            {
                btnCheckOut.Enabled = false;
            }
        }

        private void AutoCheckOn_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmLogon.Enabled = false;
            timer.Enabled = false;
        }


    }
}
