namespace scale
{
    partial class Form6
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.mYDBDataSet10 = new scale.MYDBDataSet10();
            this.lOGSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOGSTableAdapter = new scale.MYDBDataSet10TableAdapters.LOGSTableAdapter();
            this.procedureIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedureTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procuedureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOWIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOWSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALUESoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALUESupdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mYDBDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bunifuCustomDataGrid1);
            this.splitContainer1.Size = new System.Drawing.Size(638, 344);
            this.splitContainer1.SplitterDistance = 49;
            this.splitContainer1.TabIndex = 0;
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.procedureIdDataGridViewTextBoxColumn,
            this.sectionNameDataGridViewTextBoxColumn,
            this.procedureTypeDataGridViewTextBoxColumn,
            this.procuedureTimeDataGridViewTextBoxColumn,
            this.rOWIDDataGridViewTextBoxColumn,
            this.rOWSDataGridViewTextBoxColumn,
            this.vALUESoldDataGridViewTextBoxColumn,
            this.vALUESupdateDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.userIPDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid1.DataSource = this.lOGSBindingSource;
            this.bunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(638, 291);
            this.bunifuCustomDataGrid1.TabIndex = 0;
            // 
            // mYDBDataSet10
            // 
            this.mYDBDataSet10.DataSetName = "MYDBDataSet10";
            this.mYDBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOGSBindingSource
            // 
            this.lOGSBindingSource.DataMember = "LOGS";
            this.lOGSBindingSource.DataSource = this.mYDBDataSet10;
            // 
            // lOGSTableAdapter
            // 
            this.lOGSTableAdapter.ClearBeforeFill = true;
            // 
            // procedureIdDataGridViewTextBoxColumn
            // 
            this.procedureIdDataGridViewTextBoxColumn.DataPropertyName = "ProcedureId";
            this.procedureIdDataGridViewTextBoxColumn.HeaderText = "ProcedureId";
            this.procedureIdDataGridViewTextBoxColumn.Name = "procedureIdDataGridViewTextBoxColumn";
            this.procedureIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sectionNameDataGridViewTextBoxColumn
            // 
            this.sectionNameDataGridViewTextBoxColumn.DataPropertyName = "SectionName";
            this.sectionNameDataGridViewTextBoxColumn.HeaderText = "SectionName";
            this.sectionNameDataGridViewTextBoxColumn.Name = "sectionNameDataGridViewTextBoxColumn";
            this.sectionNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procedureTypeDataGridViewTextBoxColumn
            // 
            this.procedureTypeDataGridViewTextBoxColumn.DataPropertyName = "ProcedureType";
            this.procedureTypeDataGridViewTextBoxColumn.HeaderText = "ProcedureType";
            this.procedureTypeDataGridViewTextBoxColumn.Name = "procedureTypeDataGridViewTextBoxColumn";
            this.procedureTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procuedureTimeDataGridViewTextBoxColumn
            // 
            this.procuedureTimeDataGridViewTextBoxColumn.DataPropertyName = "ProcuedureTime";
            this.procuedureTimeDataGridViewTextBoxColumn.HeaderText = "ProcuedureTime";
            this.procuedureTimeDataGridViewTextBoxColumn.Name = "procuedureTimeDataGridViewTextBoxColumn";
            this.procuedureTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rOWIDDataGridViewTextBoxColumn
            // 
            this.rOWIDDataGridViewTextBoxColumn.DataPropertyName = "ROWID";
            this.rOWIDDataGridViewTextBoxColumn.HeaderText = "ROWID";
            this.rOWIDDataGridViewTextBoxColumn.Name = "rOWIDDataGridViewTextBoxColumn";
            this.rOWIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rOWSDataGridViewTextBoxColumn
            // 
            this.rOWSDataGridViewTextBoxColumn.DataPropertyName = "ROWS";
            this.rOWSDataGridViewTextBoxColumn.HeaderText = "ROWS";
            this.rOWSDataGridViewTextBoxColumn.Name = "rOWSDataGridViewTextBoxColumn";
            this.rOWSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vALUESoldDataGridViewTextBoxColumn
            // 
            this.vALUESoldDataGridViewTextBoxColumn.DataPropertyName = "VALUESold";
            this.vALUESoldDataGridViewTextBoxColumn.HeaderText = "VALUESold";
            this.vALUESoldDataGridViewTextBoxColumn.Name = "vALUESoldDataGridViewTextBoxColumn";
            this.vALUESoldDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vALUESupdateDataGridViewTextBoxColumn
            // 
            this.vALUESupdateDataGridViewTextBoxColumn.DataPropertyName = "VALUESupdate";
            this.vALUESupdateDataGridViewTextBoxColumn.HeaderText = "VALUESupdate";
            this.vALUESupdateDataGridViewTextBoxColumn.Name = "vALUESupdateDataGridViewTextBoxColumn";
            this.vALUESupdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIPDataGridViewTextBoxColumn
            // 
            this.userIPDataGridViewTextBoxColumn.DataPropertyName = "UserIP";
            this.userIPDataGridViewTextBoxColumn.HeaderText = "UserIP";
            this.userIPDataGridViewTextBoxColumn.Name = "userIPDataGridViewTextBoxColumn";
            this.userIPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 344);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mYDBDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private MYDBDataSet10 mYDBDataSet10;
        private System.Windows.Forms.BindingSource lOGSBindingSource;
        private MYDBDataSet10TableAdapters.LOGSTableAdapter lOGSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedureIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedureTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procuedureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOWIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOWSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALUESoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALUESupdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIPDataGridViewTextBoxColumn;
    }
}