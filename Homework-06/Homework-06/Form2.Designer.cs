
namespace Homework_06
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.label1 = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelCourse = new System.Windows.Forms.Label();
			this.labelDepartment = new System.Windows.Forms.Label();
			this.txt_regID = new System.Windows.Forms.TextBox();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.txt_course = new System.Windows.Forms.TextBox();
			this.txt_department = new System.Windows.Forms.TextBox();
			this.txt_search = new System.Windows.Forms.TextBox();
			this.btn_insert = new System.Windows.Forms.Button();
			this.btn_update = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_search = new System.Windows.Forms.Button();
			this.btn_displayAll = new System.Windows.Forms.Button();
			this.dataGrid_DispRec = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet2 = new Homework_06.DataSet2();
			this.profDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.authenticateDataSet = new Homework_06.AuthenticateDataSet();
			this.profDetailsTableAdapter = new Homework_06.AuthenticateDataSetTableAdapters.ProfDetailsTableAdapter();
			this.btnLogout = new System.Windows.Forms.Button();
			this.txt_email = new System.Windows.Forms.TextBox();
			this.labelEmail = new System.Windows.Forms.Label();
			this.studentDetailsTableAdapter = new Homework_06.DataSet2TableAdapters.StudentDetailsTableAdapter();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btn_Login = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_DispRec)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.profDetailsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.authenticateDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(60, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Reg ID";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.ForeColor = System.Drawing.Color.White;
			this.labelName.Location = new System.Drawing.Point(66, 104);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(45, 17);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "Name";
			// 
			// labelCourse
			// 
			this.labelCourse.AutoSize = true;
			this.labelCourse.ForeColor = System.Drawing.Color.White;
			this.labelCourse.Location = new System.Drawing.Point(58, 132);
			this.labelCourse.Name = "labelCourse";
			this.labelCourse.Size = new System.Drawing.Size(53, 17);
			this.labelCourse.TabIndex = 2;
			this.labelCourse.Text = "Course";
			// 
			// labelDepartment
			// 
			this.labelDepartment.AutoSize = true;
			this.labelDepartment.ForeColor = System.Drawing.Color.White;
			this.labelDepartment.Location = new System.Drawing.Point(29, 160);
			this.labelDepartment.Name = "labelDepartment";
			this.labelDepartment.Size = new System.Drawing.Size(82, 17);
			this.labelDepartment.TabIndex = 3;
			this.labelDepartment.Text = "Department";
			// 
			// txt_regID
			// 
			this.txt_regID.Location = new System.Drawing.Point(137, 73);
			this.txt_regID.Name = "txt_regID";
			this.txt_regID.Size = new System.Drawing.Size(677, 22);
			this.txt_regID.TabIndex = 4;
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(137, 101);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(677, 22);
			this.txt_name.TabIndex = 5;
			// 
			// txt_course
			// 
			this.txt_course.Location = new System.Drawing.Point(137, 129);
			this.txt_course.Name = "txt_course";
			this.txt_course.Size = new System.Drawing.Size(677, 22);
			this.txt_course.TabIndex = 6;
			// 
			// txt_department
			// 
			this.txt_department.Location = new System.Drawing.Point(137, 157);
			this.txt_department.Multiline = true;
			this.txt_department.Name = "txt_department";
			this.txt_department.Size = new System.Drawing.Size(677, 22);
			this.txt_department.TabIndex = 7;
			// 
			// txt_search
			// 
			this.txt_search.Location = new System.Drawing.Point(66, 249);
			this.txt_search.Name = "txt_search";
			this.txt_search.Size = new System.Drawing.Size(667, 22);
			this.txt_search.TabIndex = 8;
			// 
			// btn_insert
			// 
			this.btn_insert.Location = new System.Drawing.Point(76, 220);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.Size = new System.Drawing.Size(75, 23);
			this.btn_insert.TabIndex = 9;
			this.btn_insert.Text = "Insert";
			this.btn_insert.UseVisualStyleBackColor = true;
			this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
			// 
			// btn_update
			// 
			this.btn_update.Location = new System.Drawing.Point(186, 220);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(75, 23);
			this.btn_update.TabIndex = 10;
			this.btn_update.Text = "Update";
			this.btn_update.UseVisualStyleBackColor = true;
			this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(305, 220);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(75, 23);
			this.btn_delete.TabIndex = 11;
			this.btn_delete.Text = "Delete";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.Location = new System.Drawing.Point(406, 220);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_cancel.TabIndex = 12;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// btn_search
			// 
			this.btn_search.Location = new System.Drawing.Point(739, 248);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(75, 23);
			this.btn_search.TabIndex = 13;
			this.btn_search.Text = "Search";
			this.btn_search.UseVisualStyleBackColor = true;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// btn_displayAll
			// 
			this.btn_displayAll.Location = new System.Drawing.Point(325, 528);
			this.btn_displayAll.Name = "btn_displayAll";
			this.btn_displayAll.Size = new System.Drawing.Size(156, 23);
			this.btn_displayAll.TabIndex = 14;
			this.btn_displayAll.Text = "Display all Records";
			this.btn_displayAll.UseVisualStyleBackColor = true;
			this.btn_displayAll.Click += new System.EventHandler(this.btn_displayAll_Click);
			// 
			// dataGrid_DispRec
			// 
			this.dataGrid_DispRec.AutoGenerateColumns = false;
			this.dataGrid_DispRec.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(19)))), ((int)(((byte)(37)))));
			this.dataGrid_DispRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid_DispRec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
			this.dataGrid_DispRec.DataSource = this.studentDetailsBindingSource;
			this.dataGrid_DispRec.Location = new System.Drawing.Point(16, 277);
			this.dataGrid_DispRec.Name = "dataGrid_DispRec";
			this.dataGrid_DispRec.RowHeadersWidth = 51;
			this.dataGrid_DispRec.RowTemplate.Height = 24;
			this.dataGrid_DispRec.Size = new System.Drawing.Size(798, 245);
			this.dataGrid_DispRec.TabIndex = 15;
			this.dataGrid_DispRec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_DispRec_CellContentClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Reg ID";
			this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.Width = 125;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.Width = 125;
			// 
			// courseDataGridViewTextBoxColumn
			// 
			this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
			this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
			this.courseDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
			this.courseDataGridViewTextBoxColumn.Width = 125;
			// 
			// departmentDataGridViewTextBoxColumn
			// 
			this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
			this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
			this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
			this.departmentDataGridViewTextBoxColumn.Width = 125;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.Width = 125;
			// 
			// studentDetailsBindingSource
			// 
			this.studentDetailsBindingSource.DataMember = "StudentDetails";
			this.studentDetailsBindingSource.DataSource = this.dataSet2;
			// 
			// dataSet2
			// 
			this.dataSet2.DataSetName = "DataSet2";
			this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// profDetailsBindingSource
			// 
			this.profDetailsBindingSource.DataMember = "ProfDetails";
			this.profDetailsBindingSource.DataSource = this.authenticateDataSet;
			// 
			// authenticateDataSet
			// 
			this.authenticateDataSet.DataSetName = "AuthenticateDataSet";
			this.authenticateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// profDetailsTableAdapter
			// 
			this.profDetailsTableAdapter.ClearBeforeFill = true;
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.Color.Red;
			this.btnLogout.Location = new System.Drawing.Point(739, 528);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(75, 23);
			this.btnLogout.TabIndex = 17;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// txt_email
			// 
			this.txt_email.Location = new System.Drawing.Point(137, 185);
			this.txt_email.Multiline = true;
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(677, 22);
			this.txt_email.TabIndex = 18;
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.ForeColor = System.Drawing.Color.White;
			this.labelEmail.Location = new System.Drawing.Point(69, 188);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(42, 17);
			this.labelEmail.TabIndex = 19;
			this.labelEmail.Text = "Email";
			// 
			// studentDetailsTableAdapter
			// 
			this.studentDetailsTableAdapter.ClearBeforeFill = true;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
			this.pictureBox2.Location = new System.Drawing.Point(137, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(677, 55);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 20;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(16, 227);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(44, 44);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			// 
			// btn_Login
			// 
			this.btn_Login.BackColor = System.Drawing.Color.Lime;
			this.btn_Login.Location = new System.Drawing.Point(739, 528);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(75, 23);
			this.btn_Login.TabIndex = 21;
			this.btn_Login.Text = "Login";
			this.btn_Login.UseVisualStyleBackColor = false;
			this.btn_Login.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.ClientSize = new System.Drawing.Size(833, 563);
			this.Controls.Add(this.btn_Login);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.txt_email);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dataGrid_DispRec);
			this.Controls.Add(this.btn_displayAll);
			this.Controls.Add(this.btn_search);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_update);
			this.Controls.Add(this.btn_insert);
			this.Controls.Add(this.txt_search);
			this.Controls.Add(this.txt_department);
			this.Controls.Add(this.txt_course);
			this.Controls.Add(this.txt_name);
			this.Controls.Add(this.txt_regID);
			this.Controls.Add(this.labelDepartment);
			this.Controls.Add(this.labelCourse);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Student Information";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_DispRec)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.profDetailsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.authenticateDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelCourse;
		private System.Windows.Forms.Label labelDepartment;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.TextBox txt_regID;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.TextBox txt_course;
		private System.Windows.Forms.TextBox txt_department;
		private System.Windows.Forms.TextBox txt_search;
		private System.Windows.Forms.TextBox txt_email;
		private System.Windows.Forms.Button btn_insert;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_search;
		private System.Windows.Forms.Button btn_displayAll;
		private System.Windows.Forms.DataGridView dataGrid_DispRec;
		private System.Windows.Forms.PictureBox pictureBox1;
		private AuthenticateDataSet authenticateDataSet;
		private System.Windows.Forms.BindingSource profDetailsBindingSource;
		private AuthenticateDataSetTableAdapters.ProfDetailsTableAdapter profDetailsTableAdapter;
		private System.Windows.Forms.Button btnLogout;
		private DataSet2 dataSet2;
		private System.Windows.Forms.BindingSource studentDetailsBindingSource;
		private DataSet2TableAdapters.StudentDetailsTableAdapter studentDetailsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btn_Login;
	}
}
