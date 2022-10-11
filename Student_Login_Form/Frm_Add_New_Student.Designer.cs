namespace Student_Login_Form
{
    partial class Frm_Add_New_Student
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
            this.lbl_Add_New_Student = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Log_out = new System.Windows.Forms.Button();
            this.cb_Course = new System.Windows.Forms.ComboBox();
            this.btn_View_All_Students_List = new System.Windows.Forms.Button();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_Add_New_Student
            // 
            this.lbl_Add_New_Student.AutoSize = true;
            this.lbl_Add_New_Student.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Add_New_Student.Font = new System.Drawing.Font("Cambria", 41.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Student.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Add_New_Student.Location = new System.Drawing.Point(159, 21);
            this.lbl_Add_New_Student.Name = "lbl_Add_New_Student";
            this.lbl_Add_New_Student.Size = new System.Drawing.Size(451, 64);
            this.lbl_Add_New_Student.TabIndex = 0;
            this.lbl_Add_New_Student.Text = "Add New Student ";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.Black;
            this.lbl_Roll_No.Location = new System.Drawing.Point(95, 141);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(104, 34);
            this.lbl_Roll_No.TabIndex = 0;
            this.lbl_Roll_No.Text = "Roll No";
            this.lbl_Roll_No.Click += new System.EventHandler(this.lbl_Roll_No_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_Name.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Name.Location = new System.Drawing.Point(95, 209);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(87, 34);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Black;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(95, 287);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(141, 34);
            this.lbl_Mobile_No.TabIndex = 0;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_DOB.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.Black;
            this.lbl_DOB.Location = new System.Drawing.Point(97, 364);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(71, 34);
            this.lbl_DOB.TabIndex = 0;
            this.lbl_DOB.Text = "DOB";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_Course.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.Black;
            this.lbl_Course.Location = new System.Drawing.Point(95, 445);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(100, 34);
            this.lbl_Course.TabIndex = 0;
            this.lbl_Course.Text = "Course";
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(402, 141);
            this.tb_Roll_No.MaxLength = 5;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(324, 39);
            this.tb_Roll_No.TabIndex = 1;
            this.tb_Roll_No.Text = "45";
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(402, 208);
            this.tb_Name.MaxLength = 80;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(324, 39);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(402, 287);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(324, 39);
            this.tb_Mobile_No.TabIndex = 3;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Save.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Blue;
            this.btn_Save.Location = new System.Drawing.Point(75, 521);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(163, 39);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Log_out
            // 
            this.btn_Log_out.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_out.Location = new System.Drawing.Point(717, 3);
            this.btn_Log_out.Name = "btn_Log_out";
            this.btn_Log_out.Size = new System.Drawing.Size(99, 48);
            this.btn_Log_out.TabIndex = 8;
            this.btn_Log_out.Text = "Log out";
            this.btn_Log_out.UseVisualStyleBackColor = true;
            this.btn_Log_out.Click += new System.EventHandler(this.btn_Log_out_Click);
            // 
            // cb_Course
            // 
            this.cb_Course.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Course.FormattingEnabled = true;
            this.cb_Course.Items.AddRange(new object[] {
            "BCS",
            "BCA",
            "MCA",
            "MCS",
            "BCOM IT"});
            this.cb_Course.Location = new System.Drawing.Point(402, 444);
            this.cb_Course.Name = "cb_Course";
            this.cb_Course.Size = new System.Drawing.Size(324, 40);
            this.cb_Course.TabIndex = 5;
            // 
            // btn_View_All_Students_List
            // 
            this.btn_View_All_Students_List.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_View_All_Students_List.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_All_Students_List.ForeColor = System.Drawing.Color.Blue;
            this.btn_View_All_Students_List.Location = new System.Drawing.Point(402, 518);
            this.btn_View_All_Students_List.Name = "btn_View_All_Students_List";
            this.btn_View_All_Students_List.Size = new System.Drawing.Size(331, 42);
            this.btn_View_All_Students_List.TabIndex = 7;
            this.btn_View_All_Students_List.Text = "View All Students List";
            this.btn_View_All_Students_List.UseVisualStyleBackColor = false;
            this.btn_View_All_Students_List.Click += new System.EventHandler(this.btn_View_All_Students_List_Click);
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.CalendarFont = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(402, 375);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(324, 32);
            this.dtp_DOB.TabIndex = 9;
            // 
            // Frm_Add_New_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 562);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.btn_View_All_Students_List);
            this.Controls.Add(this.cb_Course);
            this.Controls.Add(this.btn_Log_out);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.lbl_Add_New_Student);
            this.Name = "Frm_Add_New_Student";
            this.Text = "Frm_Add_New_Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_New_Student;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Log_out;
        private System.Windows.Forms.ComboBox cb_Course;
        private System.Windows.Forms.Button btn_View_All_Students_List;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
    }
}