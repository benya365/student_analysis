namespace student_analysis
{
    partial class authForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTxtBox = new System.Windows.Forms.TextBox();
            this.passTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet = new student_analysis.mainDataSet();
            this.usersTableAdapter = new student_analysis.mainDataSetTableAdapters.usersTableAdapter();
            this.mainDataSet1 = new student_analysis.mainDataSet1();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter1 = new student_analysis.mainDataSet1TableAdapters.usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логін:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // loginTxtBox
            // 
            this.loginTxtBox.Location = new System.Drawing.Point(71, 12);
            this.loginTxtBox.Name = "loginTxtBox";
            this.loginTxtBox.Size = new System.Drawing.Size(153, 23);
            this.loginTxtBox.TabIndex = 0;
            this.loginTxtBox.TextChanged += new System.EventHandler(this.loginTxtBox_TextChanged);
            this.loginTxtBox.Enter += new System.EventHandler(this.loginTxtBox_Enter);
            // 
            // passTxtBox
            // 
            this.passTxtBox.Location = new System.Drawing.Point(71, 41);
            this.passTxtBox.Name = "passTxtBox";
            this.passTxtBox.PasswordChar = '*';
            this.passTxtBox.Size = new System.Drawing.Size(153, 23);
            this.passTxtBox.TabIndex = 1;
            this.passTxtBox.TextChanged += new System.EventHandler(this.passTxtBox_TextChanged);
            this.passTxtBox.Enter += new System.EventHandler(this.passTxtBox_Enter);
            this.passTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passTxtBox_KeyDown);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Підключитися";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Очистити поля";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(71, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(25, 25);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.mainDataSet;
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "mainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // mainDataSet1
            // 
            this.mainDataSet1.DataSetName = "mainDataSet1";
            this.mainDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.mainDataSet1;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // authForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 102);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passTxtBox);
            this.Controls.Add(this.loginTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "authForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма авторизації";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.authForm_FormClosed);
            this.Load += new System.EventHandler(this.authForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.authForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginTxtBox;
        private System.Windows.Forms.TextBox passTxtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private mainDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private mainDataSet1 mainDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private mainDataSet1TableAdapters.usersTableAdapter usersTableAdapter1;
    }
}