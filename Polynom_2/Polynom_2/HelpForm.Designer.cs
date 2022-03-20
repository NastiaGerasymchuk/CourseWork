namespace WindowsFormsApp
{
    partial class HelpForm
    {
        private System.ComponentModel.IContainer components = null;
        
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
            this.txtBoxfaculty = new System.Windows.Forms.TextBox();
            this.txtBoxCurseWork = new System.Windows.Forms.TextBox();
            this.txtBoxPolynom = new System.Windows.Forms.TextBox();
            this.txtBoxMyName = new System.Windows.Forms.TextBox();
            this.txtBoxTeacherName = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxfaculty
            // 
            this.txtBoxfaculty.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBoxfaculty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxfaculty.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxfaculty.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtBoxfaculty.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtBoxfaculty.Location = new System.Drawing.Point(37, 17);
            this.txtBoxfaculty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxfaculty.Multiline = true;
            this.txtBoxfaculty.Name = "txtBoxfaculty";
            this.txtBoxfaculty.ReadOnly = true;
            this.txtBoxfaculty.Size = new System.Drawing.Size(332, 154);
            this.txtBoxfaculty.TabIndex = 0;
            this.txtBoxfaculty.Text = "Міністерство освіти і науки України\r\nЧернівецький національний університет\r\nімені" +
    " Юрія Федьковича\r\n\r\nФакультет математики та інформатики \r\nКафедра прикладної мат" +
    "ематики та інформаційних технологій";
            this.txtBoxfaculty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxCurseWork
            // 
            this.txtBoxCurseWork.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBoxCurseWork.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxCurseWork.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxCurseWork.Font = new System.Drawing.Font("Verdana", 12.8F, System.Drawing.FontStyle.Bold);
            this.txtBoxCurseWork.Location = new System.Drawing.Point(68, 181);
            this.txtBoxCurseWork.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxCurseWork.Multiline = true;
            this.txtBoxCurseWork.Name = "txtBoxCurseWork";
            this.txtBoxCurseWork.ReadOnly = true;
            this.txtBoxCurseWork.Size = new System.Drawing.Size(280, 33);
            this.txtBoxCurseWork.TabIndex = 1;
            this.txtBoxCurseWork.Text = "КУРСОВА РОБОТА";
            this.txtBoxCurseWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxPolynom
            // 
            this.txtBoxPolynom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBoxPolynom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPolynom.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxPolynom.Font = new System.Drawing.Font("Verdana", 12.8F, System.Drawing.FontStyle.Bold);
            this.txtBoxPolynom.Location = new System.Drawing.Point(47, 218);
            this.txtBoxPolynom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxPolynom.Multiline = true;
            this.txtBoxPolynom.Name = "txtBoxPolynom";
            this.txtBoxPolynom.ReadOnly = true;
            this.txtBoxPolynom.Size = new System.Drawing.Size(332, 105);
            this.txtBoxPolynom.TabIndex = 2;
            this.txtBoxPolynom.Text = "Різнокритеріальна мінімізація повністю визначених булевих функцій в класі поляриз" +
    "ованих поліномів Ріда-Маллера";
            this.txtBoxPolynom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxMyName
            // 
            this.txtBoxMyName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBoxMyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMyName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxMyName.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtBoxMyName.Location = new System.Drawing.Point(221, 327);
            this.txtBoxMyName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxMyName.Multiline = true;
            this.txtBoxMyName.Name = "txtBoxMyName";
            this.txtBoxMyName.ReadOnly = true;
            this.txtBoxMyName.Size = new System.Drawing.Size(178, 69);
            this.txtBoxMyName.TabIndex = 3;
            this.txtBoxMyName.Text = "Виконавець:\r\nстудентка 402 групи\r\nГерасимчук Анастасія\r\n";
            // 
            // txtBoxTeacherName
            // 
            this.txtBoxTeacherName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBoxTeacherName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTeacherName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxTeacherName.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtBoxTeacherName.Location = new System.Drawing.Point(221, 408);
            this.txtBoxTeacherName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxTeacherName.Multiline = true;
            this.txtBoxTeacherName.Name = "txtBoxTeacherName";
            this.txtBoxTeacherName.ReadOnly = true;
            this.txtBoxTeacherName.Size = new System.Drawing.Size(158, 57);
            this.txtBoxTeacherName.TabIndex = 4;
            this.txtBoxTeacherName.Text = "Керівник: \r\nдоц. Філіпчук М.П.\r\n";
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBoxCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxCity.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxCity.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtBoxCity.Location = new System.Drawing.Point(120, 474);
            this.txtBoxCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxCity.Multiline = true;
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.ReadOnly = true;
            this.txtBoxCity.Size = new System.Drawing.Size(144, 24);
            this.txtBoxCity.TabIndex = 5;
            this.txtBoxCity.Text = "Чернівці - 2021\r\n";
            this.txtBoxCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(414, 509);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.txtBoxTeacherName);
            this.Controls.Add(this.txtBoxMyName);
            this.Controls.Add(this.txtBoxPolynom);
            this.Controls.Add(this.txtBoxCurseWork);
            this.Controls.Add(this.txtBoxfaculty);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Про програму";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxfaculty;
        private System.Windows.Forms.TextBox txtBoxCurseWork;
        private System.Windows.Forms.TextBox txtBoxPolynom;
        private System.Windows.Forms.TextBox txtBoxMyName;
        private System.Windows.Forms.TextBox txtBoxTeacherName;
        private System.Windows.Forms.TextBox txtBoxCity;
    }
}