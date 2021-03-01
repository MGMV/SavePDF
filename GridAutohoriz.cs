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
    public partial class GridAutohorizee : Form
    {
        Applications app;
        public GridAutohorizee(Applications app)
        {
            InitializeComponent();
            this.app = app;
        }

        private void GridAutohoriz_Load(object sender, EventArgs e)
        {
            var alls =  app.db.GetAutohorizesAll();
            for (int i = 0; i < alls.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = alls[i].id;
                dataGridView1.Rows[i].Cells[1].Value = alls[i].idUsers;
                dataGridView1.Rows[i].Cells[2].Value = alls[i].data;
                dataGridView1.Rows[i].Cells[3].Value = alls[i].trys;
            }
        }

        private void GridAutohoriz_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
