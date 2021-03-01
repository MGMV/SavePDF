using Final.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Final
{
    public partial class Autohorize : Form
    {
        Users name;
        string happy;
        System.Windows.Forms.Timer tmrr = new System.Windows.Forms.Timer() { Interval = 500 };

        Applications app;
        public Autohorize(Users user, string happy, Applications app)
        {

            InitializeComponent();
            this.app = app;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tmrr.Tick += Tmrr_Tick;
            tmrr.Start();

            this.name = user;
            this.happy = happy;
            nametxt.Text = this.name.name;
            happytxt.Text = this.happy;
            pictureBox1.Image = Image.FromFile(@"C:\Users\budik\source\repos\Final\Final\res\img\laborant_is.jpeg");
            pictureBox2.Image = Image.FromFile(@"C:\Users\budik\source\repos\Final\Final\res\img\loader.gif");


        }

        private void Tmrr_Tick(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value += 10;
            }
            catch
            {
                tmrr.Stop();
                 this.Dispose();
            }

        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Prog()
        {
            progressBar1.Value = 10;
            Thread.Sleep(200);
            progressBar1.Value = 25;
            Thread.Sleep(150);
            progressBar1.Value = 44; 
           
            Thread.Sleep(300);
            progressBar1.Value = 58;
            Thread.Sleep(400);
            progressBar1.Value = 88;
            Thread.Sleep(500);
            progressBar1.Value = 99;
            Thread.Sleep(500);
            progressBar1.Value = 100;
            Thread.Sleep(1500);
        }

    }
}
