
namespace Final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginTxt = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.LoginTxtbox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.autohorizesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginTxt
            // 
            this.LoginTxt.AutoSize = true;
            this.LoginTxt.Location = new System.Drawing.Point(97, 35);
            this.LoginTxt.Name = "LoginTxt";
            this.LoginTxt.Size = new System.Drawing.Size(44, 15);
            this.LoginTxt.TabIndex = 0;
            this.LoginTxt.Text = "Логин:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(89, 68);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(52, 15);
            this.Password.TabIndex = 1;
            this.Password.Text = "Пароль:";
            // 
            // LoginTxtbox
            // 
            this.LoginTxtbox.Location = new System.Drawing.Point(159, 32);
            this.LoginTxtbox.Name = "LoginTxtbox";
            this.LoginTxtbox.Size = new System.Drawing.Size(100, 23);
            this.LoginTxtbox.TabIndex = 2;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(159, 65);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(100, 23);
            this.PasswordTxtBox.TabIndex = 3;
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(142, 109);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(117, 23);
            this.Loginbtn.TabIndex = 4;
            this.Loginbtn.Text = "Войти";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // autohorizesBtn
            // 
            this.autohorizesBtn.Location = new System.Drawing.Point(12, 101);
            this.autohorizesBtn.Name = "autohorizesBtn";
            this.autohorizesBtn.Size = new System.Drawing.Size(57, 38);
            this.autohorizesBtn.TabIndex = 4;
            this.autohorizesBtn.Text = "Авторизации";
            this.autohorizesBtn.UseVisualStyleBackColor = true;
            this.autohorizesBtn.Click += new System.EventHandler(this.autohorizesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 168);
            this.Controls.Add(this.autohorizesBtn);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.LoginTxtbox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LoginTxt);
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginTxt;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox LoginTxtbox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Button autohorizesBtn;
    }
}

