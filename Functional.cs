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
    public partial class Functional : Form
    {
        int types;
        Applications app;
        public Functional(int types, Applications app)
        {
            InitializeComponent();
            this.app = app;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Лаборант
            reportBtn.Visible = false;
            bioBtn.Visible = false;

            // Лаборант - Исследователь
            analizBtn.Visible = false;

            // Бухгалтер
            viewReportBtn.Visible = false;
            countCompanyBtn.Visible = false;

            this.types = types;
            if (types == 1)
            {
                this.Text = "Лаборант";
                this.Size = new Size(width: 236, height: 235);
                reportBtn.Visible = true;
                bioBtn.Visible = true;
            }
            else if (types == 2)
            {
                this.Text = "Лаборант - исследователь";
                this.Size = new Size(width: 255, height: 305);
                reportBtn.Visible = true;
                bioBtn.Visible = true;
                analizBtn.Visible = true;
            }
            else if (types == 3)
            {
                this.Text = "Бухгалтер";
                this.Size = new Size(width: 255, height: 239);
                viewReportBtn.Visible = true;
                countCompanyBtn.Visible = true;
            }

        }

        private void Functional_Load(object sender, EventArgs e)
        {
        }

        private void Functional_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitTxt_MouseEnter(object sender, EventArgs e)
        {
            exitTxt.ForeColor = Color.Blue;
        }

        private void exitTxt_MouseLeave(object sender, EventArgs e)
        {
            exitTxt.ForeColor = Color.Black;
        }

        private void exitTxt_MouseDown(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void bioBtn_Click(object sender, EventArgs e)
        {
            AccesBio bio = new AccesBio(this.app);
            bio.Show();
        }
    }
}
