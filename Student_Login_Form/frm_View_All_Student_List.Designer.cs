namespace Student_Login_Form
{
    partial class frm_View_All_Student_List
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
            this.components = new System.ComponentModel.Container();
            this.lbl_View_All_Student_List = new System.Windows.Forms.Label();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.btn_Log_out = new System.Windows.Forms.Button();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Login_Form_DBDataSet1 = new Student_Login_Form.Student_Login_Form_DBDataSet1();
            this.student_DetailsTableAdapter = new Student_Login_Form.Student_Login_Form_DBDataSet1TableAdapters.Student_DetailsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.student_Login_Form_DBDataSet2 = new Student_Login_Form.Student_Login_Form_DBDataSet2();
            this.student_DetailsTableAdapter1 = new Student_Login_Form.Student_Login_Form_DBDataSet2TableAdapters.Student_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Login_Form_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Login_Form_DBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_All_Student_List
            // 
            this.lbl_View_All_Student_List.AutoSize = true;
            this.lbl_View_All_Student_List.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_View_All_Student_List.Font = new System.Drawing.Font("Cambria", 41.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_All_Student_List.ForeColor = System.Drawing.Color.Black;
            this.lbl_View_All_Student_List.Location = new System.Drawing.Point(151, 9);
            this.lbl_View_All_Student_List.Name = "lbl_View_All_Student_List";
            this.lbl_View_All_Student_List.Size = new System.Drawing.Size(530, 64);
            this.lbl_View_All_Student_List.TabIndex = 0;
            this.lbl_View_All_Student_List.Text = "View All Student List ";
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Add_New_Student.Location = new System.Drawing.Point(258, 348);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(284, 45);
            this.btn_Add_New_Student.TabIndex = 1;
            this.btn_Add_New_Student.Text = "Add New Student ";
            this.btn_Add_New_Student.UseVisualStyleBackColor = true;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // btn_Log_out
            // 
            this.btn_Log_out.BackColor = System.Drawing.Color.LightGray;
            this.btn_Log_out.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Log_out.Location = new System.Drawing.Point(750, -3);
            this.btn_Log_out.Name = "btn_Log_out";
            this.btn_Log_out.Size = new System.Drawing.Size(75, 31);
            this.btn_Log_out.TabIndex = 2;
            this.btn_Log_out.Text = "Log out";
            this.btn_Log_out.UseVisualStyleBackColor = false;
            this.btn_Log_out.Click += new System.EventHandler(this.btn_Log_out_Click);
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student Details";
            this.studentDetailsBindingSource.DataSource = this.student_Login_Form_DBDataSet1;
            // 
            // student_Login_Form_DBDataSet1
            // 
            this.student_Login_Form_DBDataSet1.DataSetName = "Student_Login_Form_DBDataSet1";
            this.student_Login_Form_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentDetailsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(144, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 266);
            this.dataGridView1.TabIndex = 3;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll No";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // studentDetailsBindingSource1
            // 
            this.studentDetailsBindingSource1.DataMember = "Student Details";
            this.studentDetailsBindingSource1.DataSource = this.student_Login_Form_DBDataSet2;
            // 
            // student_Login_Form_DBDataSet2
            // 
            this.student_Login_Form_DBDataSet2.DataSetName = "Student_Login_Form_DBDataSet2";
            this.student_Login_Form_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_DetailsTableAdapter1
            // 
            this.student_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_View_All_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 405);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Log_out);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.lbl_View_All_Student_List);
            this.Name = "frm_View_All_Student_List";
            this.Text = "frm_View_All_Student_List";
            this.Load += new System.EventHandler(this.frm_View_All_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Login_Form_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Login_Form_DBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_All_Student_List;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Button btn_Log_out;
        private Student_Login_Form_DBDataSet1 student_Login_Form_DBDataSet1;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private Student_Login_Form_DBDataSet1TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Student_Login_Form_DBDataSet2 student_Login_Form_DBDataSet2;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource1;
        private Student_Login_Form_DBDataSet2TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}