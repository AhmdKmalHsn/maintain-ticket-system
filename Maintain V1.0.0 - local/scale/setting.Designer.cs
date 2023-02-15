namespace scale
{
    partial class setting
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersViewBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.mYDBDataSet5 = new scale.MYDBDataSet5();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new scale.DatabaseDataSet();
            this.usersViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.serverName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DBUser = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DBPass = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DBName = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.usersViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usersViewTableAdapter1 = new scale.MYDBDataSet5TableAdapters.UsersViewTableAdapter();
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mYDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.masterDataDataGridViewTextBoxColumn,
            this.ticketDataGridViewTextBoxColumn,
            this.reportDataGridViewTextBoxColumn,
            this.settingDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersViewBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(49, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(601, 235);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cell_DClick);
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // masterDataDataGridViewTextBoxColumn
            // 
            this.masterDataDataGridViewTextBoxColumn.DataPropertyName = "master_Data";
            this.masterDataDataGridViewTextBoxColumn.HeaderText = "master_Data";
            this.masterDataDataGridViewTextBoxColumn.Name = "masterDataDataGridViewTextBoxColumn";
            this.masterDataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketDataGridViewTextBoxColumn
            // 
            this.ticketDataGridViewTextBoxColumn.DataPropertyName = "Ticket";
            this.ticketDataGridViewTextBoxColumn.HeaderText = "Ticket";
            this.ticketDataGridViewTextBoxColumn.Name = "ticketDataGridViewTextBoxColumn";
            this.ticketDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportDataGridViewTextBoxColumn
            // 
            this.reportDataGridViewTextBoxColumn.DataPropertyName = "Report";
            this.reportDataGridViewTextBoxColumn.HeaderText = "Report";
            this.reportDataGridViewTextBoxColumn.Name = "reportDataGridViewTextBoxColumn";
            this.reportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // settingDataGridViewTextBoxColumn
            // 
            this.settingDataGridViewTextBoxColumn.DataPropertyName = "Setting";
            this.settingDataGridViewTextBoxColumn.HeaderText = "Setting";
            this.settingDataGridViewTextBoxColumn.Name = "settingDataGridViewTextBoxColumn";
            this.settingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersViewBindingSource3
            // 
            this.usersViewBindingSource3.DataMember = "UsersView";
            this.usersViewBindingSource3.DataSource = this.mYDBDataSet5;
            // 
            // mYDBDataSet5
            // 
            this.mYDBDataSet5.DataSetName = "MYDBDataSet5";
            this.mYDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersViewBindingSource1
            // 
            this.usersViewBindingSource1.DataMember = "UsersView";
            this.usersViewBindingSource1.DataSource = this.mYDBDataSet5;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(362, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "حفظ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(168, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "رجوع";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // serverName
            // 
            this.serverName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverName.FormattingEnabled = true;
            this.serverName.Location = new System.Drawing.Point(207, 330);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(417, 32);
            this.serverName.TabIndex = 3;
            this.serverName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(45, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(90, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "DB user";
            // 
            // DBUser
            // 
            this.DBUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DBUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBUser.FormattingEnabled = true;
            this.DBUser.Location = new System.Drawing.Point(207, 415);
            this.DBUser.Name = "DBUser";
            this.DBUser.Size = new System.Drawing.Size(136, 32);
            this.DBUser.TabIndex = 5;
            this.DBUser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(369, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "DB pass";
            // 
            // DBPass
            // 
            this.DBPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DBPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBPass.FormattingEnabled = true;
            this.DBPass.Location = new System.Drawing.Point(477, 418);
            this.DBPass.Name = "DBPass";
            this.DBPass.Size = new System.Drawing.Size(147, 32);
            this.DBPass.TabIndex = 9;
            this.DBPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(79, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "DB name";
            // 
            // DBName
            // 
            this.DBName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBName.FormattingEnabled = true;
            this.DBName.Location = new System.Drawing.Point(207, 371);
            this.DBName.Name = "DBName";
            this.DBName.Size = new System.Drawing.Size(417, 32);
            this.DBName.TabIndex = 13;
            this.DBName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(49, 281);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(601, 31);
            this.textBox1.TabIndex = 15;
            // 
            // usersViewBindingSource2
            // 
            this.usersViewBindingSource2.DataMember = "UsersView";
            this.usersViewBindingSource2.DataSource = this.mYDBDataSet5;
            // 
            // usersViewTableAdapter1
            // 
            this.usersViewTableAdapter1.ClearBeforeFill = true;
            // 
            // usersViewBindingSource
            // 
            this.usersViewBindingSource.DataMember = "UsersView";
            this.usersViewBindingSource.DataSource = this.mYDBDataSet5;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(49, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "أضافة ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(575, 475);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 37);
            this.button4.TabIndex = 17;
            this.button4.Text = "log";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 524);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DBName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DBPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DBUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "setting";
            this.Text = "setting";
            this.Activated += new System.EventHandler(this.Active);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mYDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet1 databaseDataSet1;
        private DatabaseDataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox serverName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DBUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DBPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DBName;
        private System.Windows.Forms.TextBox textBox1;
        private MYDBDataSet5 mYDBDataSet5;
        private System.Windows.Forms.BindingSource usersViewBindingSource2;
        private MYDBDataSet5TableAdapters.UsersViewTableAdapter usersViewTableAdapter1;
        private System.Windows.Forms.BindingSource usersViewBindingSource1;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn settingDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usersViewBindingSource3;
        private System.Windows.Forms.Button button4;
    }
}