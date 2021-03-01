
namespace Final
{
    partial class Functional
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
            this.bioBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.analizBtn = new System.Windows.Forms.Button();
            this.viewReportBtn = new System.Windows.Forms.Button();
            this.countCompanyBtn = new System.Windows.Forms.Button();
            this.exitTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bioBtn
            // 
            this.bioBtn.Location = new System.Drawing.Point(30, 56);
            this.bioBtn.Name = "bioBtn";
            this.bioBtn.Size = new System.Drawing.Size(177, 23);
            this.bioBtn.TabIndex = 0;
            this.bioBtn.Text = "Принять биоматериал";
            this.bioBtn.UseVisualStyleBackColor = true;
            this.bioBtn.Visible = false;
            this.bioBtn.Click += new System.EventHandler(this.bioBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.Location = new System.Drawing.Point(60, 126);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(101, 23);
            this.reportBtn.TabIndex = 1;
            this.reportBtn.Text = "Отчет";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Visible = false;
            // 
            // analizBtn
            // 
            this.analizBtn.Location = new System.Drawing.Point(49, 207);
            this.analizBtn.Name = "analizBtn";
            this.analizBtn.Size = new System.Drawing.Size(123, 23);
            this.analizBtn.TabIndex = 2;
            this.analizBtn.Text = "Анализатор";
            this.analizBtn.UseVisualStyleBackColor = true;
            this.analizBtn.Visible = false;
            // 
            // viewReportBtn
            // 
            this.viewReportBtn.Location = new System.Drawing.Point(30, 56);
            this.viewReportBtn.Name = "viewReportBtn";
            this.viewReportBtn.Size = new System.Drawing.Size(177, 23);
            this.viewReportBtn.TabIndex = 0;
            this.viewReportBtn.Text = "Просмотреть отчеты";
            this.viewReportBtn.UseVisualStyleBackColor = true;
            this.viewReportBtn.Visible = false;
            // 
            // countCompanyBtn
            // 
            this.countCompanyBtn.Location = new System.Drawing.Point(60, 111);
            this.countCompanyBtn.Name = "countCompanyBtn";
            this.countCompanyBtn.Size = new System.Drawing.Size(101, 53);
            this.countCompanyBtn.TabIndex = 1;
            this.countCompanyBtn.Text = "Сформировать счет страховой компании";
            this.countCompanyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.countCompanyBtn.UseVisualStyleBackColor = true;
            this.countCompanyBtn.Visible = false;
            // 
            // exitTxt
            // 
            this.exitTxt.AutoSize = true;
            this.exitTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.exitTxt.Location = new System.Drawing.Point(12, 9);
            this.exitTxt.Name = "exitTxt";
            this.exitTxt.Size = new System.Drawing.Size(42, 15);
            this.exitTxt.TabIndex = 3;
            this.exitTxt.Text = "Выход";
            this.exitTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exitTxt_MouseDown);
            this.exitTxt.MouseEnter += new System.EventHandler(this.exitTxt_MouseEnter);
            this.exitTxt.MouseLeave += new System.EventHandler(this.exitTxt_MouseLeave);
            // 
            // Functional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 200);
            this.Controls.Add(this.exitTxt);
            this.Controls.Add(this.analizBtn);
            this.Controls.Add(this.countCompanyBtn);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.viewReportBtn);
            this.Controls.Add(this.bioBtn);
            this.Name = "Functional";
            this.Text = "Functional";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Functional_FormClosed);
            this.Load += new System.EventHandler(this.Functional_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bioBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button analizBtn;
        private System.Windows.Forms.Button viewReportBtn;
        private System.Windows.Forms.Button countCompanyBtn;
        private System.Windows.Forms.Label exitTxt;
    }
}