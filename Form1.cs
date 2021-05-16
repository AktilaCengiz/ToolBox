using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
using System.Data.SqlClient;

namespace ToolBox_Widget
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        globalKeyboardHook gkh = new globalKeyboardHook();


        // Program Load -here-
        private void Form1_Load(object sender, EventArgs e)
        {


            gkh.HookedKeys.Add(Keys.CapsLock);
            //gkh.HookedKeys.Add(Keys.B);
            //gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
            MessageBox.Show("Programımız betadır. Hata ve sıkıntılarda lütfen web sitemizden bildirmeyi unutmayınız. İyi kullanımlar.");
        }
        public void SetTimeout(Action action, int timeout)
        {
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = timeout;
            timer.Tick += delegate (object sender, EventArgs args)
            {
                action();
                timer.Stop();
            };
            timer.Start();
        }

        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            CapsLock capsLock = new CapsLock();

            if (timer1.Enabled == true)
            {
                if (Control.IsKeyLocked(Keys.CapsLock))
                {
                    capsLock.ChangeText("Aa");
                    capsLock.Show();
                    SetTimeout(capsLock.Close, 500);
                }
                else
                {
                    capsLock.ChangeText("aa");
                    capsLock.Show();
                    SetTimeout(capsLock.Close, 500);
                }
            }
            else
            {
                return;
            }
        }

      /*  void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Yes B");
        }
      */


        // "Kaydet" Button Events -here-
        private void button1_Click(object sender, EventArgs e)
        {
 
            if (checkBox1.Checked == true) {
                label4.Text = "Aktif";
                label4.ForeColor = SystemColors.ButtonFace;
                timer1.Enabled = true;
            } else {
                label4.Text = "Deaktif";
                label4.ForeColor = SystemColors.GrayText;
                timer1.Enabled = false;
            }
        }

        //BackGround doubleClickFunction -here-
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }


        //Windows Close Section -here-
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            notifyIcon1.Icon = Icon;
            notifyIcon1.ShowBalloonTip(2000);
        }

        //"Kapat" Section -here-
        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Şimdilik burası boş gözüküyor.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://venosastudio.com");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
