using Final.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final
{
    public partial class AccesBio : Form
    {
        Applications app;
        public AccesBio(Applications app)
        {
            InitializeComponent();
            this.app = app;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if(kodTxt.Text != "")
            {
                app.db.Insert("Bio", "kod, other", $"'{kodTxt.Text}', '{otherTxt.Text}'");
                this.Dispose();
            }    
            else
            {
                MessageBox.Show("Введите код!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void canselBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
