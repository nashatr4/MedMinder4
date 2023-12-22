
namespace MedMinder4
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxMedName = new System.Windows.Forms.TextBox();
            this.numericUpDownAmountofMedicine = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownConsumptionTime = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerInitialTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountofMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConsumptionTime)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMedName
            // 
            this.textBoxMedName.Location = new System.Drawing.Point(356, 72);
            this.textBoxMedName.Name = "textBoxMedName";
            this.textBoxMedName.Size = new System.Drawing.Size(294, 22);
            this.textBoxMedName.TabIndex = 1;
            // 
            // numericUpDownAmountofMedicine
            // 
            this.numericUpDownAmountofMedicine.Location = new System.Drawing.Point(356, 236);
            this.numericUpDownAmountofMedicine.Name = "numericUpDownAmountofMedicine";
            this.numericUpDownAmountofMedicine.Size = new System.Drawing.Size(294, 22);
            this.numericUpDownAmountofMedicine.TabIndex = 2;
            // 
            // numericUpDownConsumptionTime
            // 
            this.numericUpDownConsumptionTime.Location = new System.Drawing.Point(356, 125);
            this.numericUpDownConsumptionTime.Name = "numericUpDownConsumptionTime";
            this.numericUpDownConsumptionTime.Size = new System.Drawing.Size(294, 22);
            this.numericUpDownConsumptionTime.TabIndex = 3;
            // 
            // dateTimePickerInitialTime
            // 
            this.dateTimePickerInitialTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerInitialTime.Location = new System.Drawing.Point(356, 177);
            this.dateTimePickerInitialTime.Name = "dateTimePickerInitialTime";
            this.dateTimePickerInitialTime.Size = new System.Drawing.Size(294, 22);
            this.dateTimePickerInitialTime.TabIndex = 4;
            this.dateTimePickerInitialTime.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Medicine Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Consumption Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Initial Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(59, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount of Medicine";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(982, 578);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerInitialTime);
            this.Controls.Add(this.numericUpDownConsumptionTime);
            this.Controls.Add(this.numericUpDownAmountofMedicine);
            this.Controls.Add(this.textBoxMedName);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Add Medicine";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountofMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConsumptionTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxMedName;
        private System.Windows.Forms.NumericUpDown numericUpDownAmountofMedicine;
        private System.Windows.Forms.NumericUpDown numericUpDownConsumptionTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerInitialTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}