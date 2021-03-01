
namespace Final
{
    partial class AccesBio
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
            this.kodTxt = new System.Windows.Forms.TextBox();
            this.kodLabel = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.canselBtn = new System.Windows.Forms.Button();
            this.otherTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kodTxt
            // 
            this.kodTxt.Location = new System.Drawing.Point(98, 12);
            this.kodTxt.Name = "kodTxt";
            this.kodTxt.PlaceholderText = "Введите код";
            this.kodTxt.Size = new System.Drawing.Size(247, 23);
            this.kodTxt.TabIndex = 0;
            // 
            // kodLabel
            // 
            this.kodLabel.AutoSize = true;
            this.kodLabel.Location = new System.Drawing.Point(62, 15);
            this.kodLabel.Name = "kodLabel";
            this.kodLabel.Size = new System.Drawing.Size(30, 15);
            this.kodLabel.TabIndex = 1;
            this.kodLabel.Text = "Код:";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(86, 112);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // canselBtn
            // 
            this.canselBtn.Location = new System.Drawing.Point(256, 112);
            this.canselBtn.Name = "canselBtn";
            this.canselBtn.Size = new System.Drawing.Size(75, 23);
            this.canselBtn.TabIndex = 2;
            this.canselBtn.Text = "Отмена";
            this.canselBtn.UseVisualStyleBackColor = true;
            this.canselBtn.Click += new System.EventHandler(this.canselBtn_Click);
            // 
            // otherTxt
            // 
            this.otherTxt.Location = new System.Drawing.Point(98, 41);
            this.otherTxt.Multiline = true;
            this.otherTxt.Name = "otherTxt";
            this.otherTxt.PlaceholderText = "Исследования...";
            this.otherTxt.Size = new System.Drawing.Size(247, 53);
            this.otherTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Исследования:";
            // 
            // AccesBio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 174);
            this.Controls.Add(this.canselBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kodLabel);
            this.Controls.Add(this.otherTxt);
            this.Controls.Add(this.kodTxt);
            this.Name = "AccesBio";
            this.Text = "Прием биоматериала";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kodTxt;
        private System.Windows.Forms.Label kodLabel;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button canselBtn;
        private System.Windows.Forms.TextBox otherTxt;
        private System.Windows.Forms.Label label1;
    }
}