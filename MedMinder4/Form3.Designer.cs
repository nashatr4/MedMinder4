
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountofMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConsumptionTime)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMedName
            // 
            this.textBoxMedName.Location = new System.Drawing.Point(375, 99);
            this.textBoxMedName.Name = "textBoxMedName";
            this.textBoxMedName.Size = new System.Drawing.Size(100, 22);
            this.textBoxMedName.TabIndex = 1;
            // 
            // numericUpDownAmountofMedicine
            // 
            this.numericUpDownAmountofMedicine.Location = new System.Drawing.Point(375, 262);
            this.numericUpDownAmountofMedicine.Name = "numericUpDownAmountofMedicine";
            this.numericUpDownAmountofMedicine.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownAmountofMedicine.TabIndex = 2;
            // 
            // numericUpDownConsumptionTime
            // 
            this.numericUpDownConsumptionTime.Location = new System.Drawing.Point(375, 152);
            this.numericUpDownConsumptionTime.Name = "numericUpDownConsumptionTime";
            this.numericUpDownConsumptionTime.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownConsumptionTime.TabIndex = 3;
            // 
            // dateTimePickerInitialTime
            // 
            this.dateTimePickerInitialTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerInitialTime.Location = new System.Drawing.Point(375, 209);
            this.dateTimePickerInitialTime.Name = "dateTimePickerInitialTime";
            this.dateTimePickerInitialTime.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerInitialTime.TabIndex = 4;
            this.dateTimePickerInitialTime.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerInitialTime);
            this.Controls.Add(this.numericUpDownConsumptionTime);
            this.Controls.Add(this.numericUpDownAmountofMedicine);
            this.Controls.Add(this.textBoxMedName);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
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
    }
}