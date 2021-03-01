
namespace Final
{
    partial class Autohorize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.autohoriz = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.Label();
            this.happytxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // autohoriz
            // 
            this.autohoriz.AutoSize = true;
            this.autohoriz.Location = new System.Drawing.Point(165, 9);
            this.autohoriz.Name = "autohoriz";
            this.autohoriz.Size = new System.Drawing.Size(87, 15);
            this.autohoriz.TabIndex = 0;
            this.autohoriz.Text = "Авторизация...";
            // 
            // nametxt
            // 
            this.nametxt.AutoSize = true;
            this.nametxt.Location = new System.Drawing.Point(12, 68);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(109, 15);
            this.nametxt.TabIndex = 1;
            this.nametxt.Text = "Имя пользователя";
            // 
            // happytxt
            // 
            this.happytxt.AutoSize = true;
            this.happytxt.Location = new System.Drawing.Point(12, 97);
            this.happytxt.Name = "happytxt";
            this.happytxt.Size = new System.Drawing.Size(90, 15);
            this.happytxt.TabIndex = 2;
            this.happytxt.Text = "Дата рождения";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(278, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(61, 156);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(339, 11);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(192, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Autohorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 179);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.happytxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.autohoriz);
            this.Name = "Autohorize";
            this.Text = "Autohorize";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label autohoriz;
        private System.Windows.Forms.Label nametxt;
        private System.Windows.Forms.Label happytxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}