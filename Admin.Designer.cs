namespace Курсач
{
    partial class Admin
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
            this.namerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gotovilDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idvkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otsytstvDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.infchasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grouppDataSet = new Курсач.GrouppDataSet();
            this.inf_chasTableAdapter = new Курсач.GrouppDataSetTableAdapters.Inf_chasTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infchasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grouppDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namerDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.gotovilDataGridViewCheckBoxColumn,
            this.idvkDataGridViewTextBoxColumn,
            this.otsytstvDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.infchasBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 474);
            this.dataGridView1.TabIndex = 0;
            // 
            // namerDataGridViewTextBoxColumn
            // 
            this.namerDataGridViewTextBoxColumn.DataPropertyName = "Namer";
            this.namerDataGridViewTextBoxColumn.HeaderText = "Namer";
            this.namerDataGridViewTextBoxColumn.Name = "namerDataGridViewTextBoxColumn";
            this.namerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // gotovilDataGridViewCheckBoxColumn
            // 
            this.gotovilDataGridViewCheckBoxColumn.DataPropertyName = "Gotovil";
            this.gotovilDataGridViewCheckBoxColumn.HeaderText = "Gotovil";
            this.gotovilDataGridViewCheckBoxColumn.Name = "gotovilDataGridViewCheckBoxColumn";
            // 
            // idvkDataGridViewTextBoxColumn
            // 
            this.idvkDataGridViewTextBoxColumn.DataPropertyName = "Id_vk";
            this.idvkDataGridViewTextBoxColumn.HeaderText = "Id_vk";
            this.idvkDataGridViewTextBoxColumn.Name = "idvkDataGridViewTextBoxColumn";
            // 
            // otsytstvDataGridViewCheckBoxColumn
            // 
            this.otsytstvDataGridViewCheckBoxColumn.DataPropertyName = "Otsytstv";
            this.otsytstvDataGridViewCheckBoxColumn.HeaderText = "Otsytstv";
            this.otsytstvDataGridViewCheckBoxColumn.Name = "otsytstvDataGridViewCheckBoxColumn";
            // 
            // infchasBindingSource
            // 
            this.infchasBindingSource.DataMember = "Inf_chas";
            this.infchasBindingSource.DataSource = this.grouppDataSet;
            // 
            // grouppDataSet
            // 
            this.grouppDataSet.DataSetName = "GrouppDataSet";
            this.grouppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inf_chasTableAdapter
            // 
            this.inf_chasTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 474);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infchasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grouppDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GrouppDataSet grouppDataSet;
        private System.Windows.Forms.BindingSource infchasBindingSource;
        private GrouppDataSetTableAdapters.Inf_chasTableAdapter inf_chasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gotovilDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn otsytstvDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Timer timer1;
    }
}