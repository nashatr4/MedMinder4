
namespace MedMinder4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medicineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumptionTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountofMedicineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicine4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medMinderDataSet2 = new MedMinder4.MedMinderDataSet2();
            this.medicine4TableAdapter = new MedMinder4.MedMinderDataSet2TableAdapters.Medicine4TableAdapter();
            this.medicine2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medMinderDataSet1 = new MedMinder4.MedMinderDataSet1();
            this.medicine2TableAdapter = new MedMinder4.MedMinderDataSet1TableAdapters.Medicine2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicine4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medMinderDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicine2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medMinderDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicineNameDataGridViewTextBoxColumn,
            this.consumptionTimeDataGridViewTextBoxColumn,
            this.initialTimeDataGridViewTextBoxColumn,
            this.amountofMedicineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medicine4BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(982, 578);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // medicineNameDataGridViewTextBoxColumn
            // 
            this.medicineNameDataGridViewTextBoxColumn.DataPropertyName = "MedicineName";
            this.medicineNameDataGridViewTextBoxColumn.HeaderText = "MedicineName";
            this.medicineNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicineNameDataGridViewTextBoxColumn.Name = "medicineNameDataGridViewTextBoxColumn";
            this.medicineNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // consumptionTimeDataGridViewTextBoxColumn
            // 
            this.consumptionTimeDataGridViewTextBoxColumn.DataPropertyName = "ConsumptionTime";
            this.consumptionTimeDataGridViewTextBoxColumn.HeaderText = "ConsumptionTime";
            this.consumptionTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.consumptionTimeDataGridViewTextBoxColumn.Name = "consumptionTimeDataGridViewTextBoxColumn";
            this.consumptionTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // initialTimeDataGridViewTextBoxColumn
            // 
            this.initialTimeDataGridViewTextBoxColumn.DataPropertyName = "InitialTime";
            this.initialTimeDataGridViewTextBoxColumn.HeaderText = "InitialTime";
            this.initialTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.initialTimeDataGridViewTextBoxColumn.Name = "initialTimeDataGridViewTextBoxColumn";
            this.initialTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountofMedicineDataGridViewTextBoxColumn
            // 
            this.amountofMedicineDataGridViewTextBoxColumn.DataPropertyName = "AmountofMedicine";
            this.amountofMedicineDataGridViewTextBoxColumn.HeaderText = "AmountofMedicine";
            this.amountofMedicineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountofMedicineDataGridViewTextBoxColumn.Name = "amountofMedicineDataGridViewTextBoxColumn";
            this.amountofMedicineDataGridViewTextBoxColumn.Width = 125;
            // 
            // medicine4BindingSource
            // 
            this.medicine4BindingSource.DataMember = "Medicine4";
            this.medicine4BindingSource.DataSource = this.medMinderDataSet2;
            // 
            // medMinderDataSet2
            // 
            this.medMinderDataSet2.DataSetName = "MedMinderDataSet2";
            this.medMinderDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicine4TableAdapter
            // 
            this.medicine4TableAdapter.ClearBeforeFill = true;
            // 
            // medicine2BindingSource
            // 
            this.medicine2BindingSource.DataSource = this.medMinderDataSet1;
            this.medicine2BindingSource.Position = 0;
            // 
            // medMinderDataSet1
            // 
            this.medMinderDataSet1.DataSetName = "MedMinderDataSet1";
            this.medMinderDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicine2TableAdapter
            // 
            this.medicine2TableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 578);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "List of medicine";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicine4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medMinderDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicine2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medMinderDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MedMinderDataSet1 medMinderDataSet1;
        private System.Windows.Forms.BindingSource medicine2BindingSource;
        private MedMinderDataSet1TableAdapters.Medicine2TableAdapter medicine2TableAdapter;
        private MedMinderDataSet2 medMinderDataSet2;
        private System.Windows.Forms.BindingSource medicine4BindingSource;
        private MedMinderDataSet2TableAdapters.Medicine4TableAdapter medicine4TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumptionTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountofMedicineDataGridViewTextBoxColumn;
    }
}
