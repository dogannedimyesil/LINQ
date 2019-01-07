namespace LINQ
{
    partial class Form2
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
            this.btn_newStaff = new System.Windows.Forms.Button();
            this.lbl_Staff = new System.Windows.Forms.Label();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_StaffAge = new System.Windows.Forms.Label();
            this.lbl_StaffSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_newStaff
            // 
            this.btn_newStaff.Location = new System.Drawing.Point(53, 21);
            this.btn_newStaff.Name = "btn_newStaff";
            this.btn_newStaff.Size = new System.Drawing.Size(90, 23);
            this.btn_newStaff.TabIndex = 0;
            this.btn_newStaff.Text = "Yeni Personel";
            this.btn_newStaff.UseVisualStyleBackColor = true;
            this.btn_newStaff.Click += new System.EventHandler(this.btn_newStaff_Click);
            // 
            // lbl_Staff
            // 
            this.lbl_Staff.AutoSize = true;
            this.lbl_Staff.Location = new System.Drawing.Point(13, 67);
            this.lbl_Staff.Name = "lbl_Staff";
            this.lbl_Staff.Size = new System.Drawing.Size(120, 13);
            this.lbl_Staff.TabIndex = 1;
            this.lbl_Staff.Text = "Şu anda 0 personel var.";
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Location = new System.Drawing.Point(13, 91);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(149, 13);
            this.lbl_Salary.TabIndex = 2;
            this.lbl_Salary.Text = "Personel maaşı ortalama 0 TL.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Son eklenen personelin";
            // 
            // lbl_StaffAge
            // 
            this.lbl_StaffAge.AutoSize = true;
            this.lbl_StaffAge.Location = new System.Drawing.Point(35, 138);
            this.lbl_StaffAge.Name = "lbl_StaffAge";
            this.lbl_StaffAge.Size = new System.Drawing.Size(34, 13);
            this.lbl_StaffAge.TabIndex = 4;
            this.lbl_StaffAge.Text = "yaşı 0";
            // 
            // lbl_StaffSalary
            // 
            this.lbl_StaffSalary.AutoSize = true;
            this.lbl_StaffSalary.Location = new System.Drawing.Point(35, 160);
            this.lbl_StaffSalary.Name = "lbl_StaffSalary";
            this.lbl_StaffSalary.Size = new System.Drawing.Size(43, 13);
            this.lbl_StaffSalary.TabIndex = 5;
            this.lbl_StaffSalary.Text = "maaşı 0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 208);
            this.Controls.Add(this.lbl_StaffSalary);
            this.Controls.Add(this.lbl_StaffAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Salary);
            this.Controls.Add(this.lbl_Staff);
            this.Controls.Add(this.btn_newStaff);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_newStaff;
        private System.Windows.Forms.Label lbl_Staff;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_StaffAge;
        private System.Windows.Forms.Label lbl_StaffSalary;
    }
}