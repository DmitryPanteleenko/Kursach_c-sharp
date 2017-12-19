namespace Курсач
{
    partial class PasChange
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
            this.grouppDataSet = new Курсач.GrouppDataSet();
            this.logpasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logpasTableAdapter = new Курсач.GrouppDataSetTableAdapters.logpasTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grouppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logpasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.logDataGridViewTextBoxColumn,
            this.pasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.logpasBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(282, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // grouppDataSet
            // 
            this.grouppDataSet.DataSetName = "GrouppDataSet";
            this.grouppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logpasBindingSource
            // 
            this.logpasBindingSource.DataMember = "logpas";
            this.logpasBindingSource.DataSource = this.grouppDataSet;
            // 
            // logpasTableAdapter
            // 
            this.logpasTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // logDataGridViewTextBoxColumn
            // 
            this.logDataGridViewTextBoxColumn.DataPropertyName = "log";
            this.logDataGridViewTextBoxColumn.HeaderText = "log";
            this.logDataGridViewTextBoxColumn.Name = "logDataGridViewTextBoxColumn";
            // 
            // pasDataGridViewTextBoxColumn
            // 
            this.pasDataGridViewTextBoxColumn.DataPropertyName = "pas";
            this.pasDataGridViewTextBoxColumn.HeaderText = "pas";
            this.pasDataGridViewTextBoxColumn.Name = "pasDataGridViewTextBoxColumn";
            // 
            // PasChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PasChange";
            this.Text = "PasChange";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PasChange_FormClosed);
            this.Load += new System.EventHandler(this.PasChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grouppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logpasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GrouppDataSet grouppDataSet;
        private System.Windows.Forms.BindingSource logpasBindingSource;
        private GrouppDataSetTableAdapters.logpasTableAdapter logpasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasDataGridViewTextBoxColumn;
    }
}