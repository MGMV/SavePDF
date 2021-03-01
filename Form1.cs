using Final.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Form1 : Form
    {
        Applications app;

        Autohorize autohorize;
        GridAutohorizee gridAutohoriz;
        Functional functional;

        Users user;

        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
           

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            user = app.db.SelectUsers(LoginTxtbox.Text);
            if (app.db.SelectUsers("login", "id", user.id.ToString()) == "" || user.password != PasswordTxtBox.Text)
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                app.db.DbAutohorize(LoginTxtbox.Text, DateTime.Now.ToString(), 0);
            }
            else
            {
                autohorize = new Autohorize(user, "01.01.2000", this.app);
                autohorize.Disposed += Autohorize_Disposed;
                autohorize.Show();
                app.db.DbAutohorize(user.name, DateTime.Now.ToString(), 1);
                this.Hide();
            }
        }

        private void Functional_Disposed(object sender, EventArgs e)
        {
            LoginTxtbox.Text = "";
            PasswordTxtBox.Text = "";
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            app = new Applications();
            app.db.Conected();
        }

        private void Autohorize_Disposed(object sender, EventArgs e)
        {
            if (user.type == 0)
                MessageBox.Show("Неизвестная ошибка 0x1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                functional = new Functional(user.type, this.app);
                functional.Disposed += Functional_Disposed;
                functional.Show();
            }

        }

        private void autohorizesBtn_Click(object sender, EventArgs e)
        {
            gridAutohoriz = new GridAutohorizee(this.app);
            gridAutohoriz.Disposed += GridAutohoriz_Disposed;
            gridAutohoriz.Show();
            this.Hide();
        }

        private void GridAutohoriz_Disposed(object sender, EventArgs e)
        {
            this.Show();
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                functional.Disposed -= Functional_Disposed;
            }
            catch { }
            try
            {
                gridAutohoriz.Disposed -= GridAutohoriz_Disposed;
            }
            catch { }
            try
            {
                autohorize.Disposed -= Autohorize_Disposed;
            }
            catch { }
        }
    }
}
