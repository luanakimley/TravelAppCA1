namespace TravelAppCA1
{
    partial class TravelApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.originComboBox = new System.Windows.Forms.ComboBox();
            this.destinationComboBox = new System.Windows.Forms.ComboBox();
            this.departureDate = new System.Windows.Forms.DateTimePicker();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 1058);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(69, 433);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(950, 388);
            this.listBox1.TabIndex = 2;
            // 
            // originComboBox
            // 
            this.originComboBox.DropDownHeight = 100;
            this.originComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.originComboBox.FormattingEnabled = true;
            this.originComboBox.IntegralHeight = false;
            this.originComboBox.ItemHeight = 45;
            this.originComboBox.Location = new System.Drawing.Point(69, 65);
            this.originComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.originComboBox.Name = "originComboBox";
            this.originComboBox.Size = new System.Drawing.Size(264, 53);
            this.originComboBox.TabIndex = 3;
            this.originComboBox.Text = "From";
            // 
            // destinationComboBox
            // 
            this.destinationComboBox.DropDownHeight = 100;
            this.destinationComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.destinationComboBox.FormattingEnabled = true;
            this.destinationComboBox.IntegralHeight = false;
            this.destinationComboBox.ItemHeight = 45;
            this.destinationComboBox.Location = new System.Drawing.Point(364, 65);
            this.destinationComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.destinationComboBox.Name = "destinationComboBox";
            this.destinationComboBox.Size = new System.Drawing.Size(264, 53);
            this.destinationComboBox.TabIndex = 4;
            this.destinationComboBox.Text = "To";
            // 
            // departureDate
            // 
            this.departureDate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departureDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departureDate.Location = new System.Drawing.Point(667, 68);
            this.departureDate.Name = "departureDate";
            this.departureDate.Size = new System.Drawing.Size(530, 50);
            this.departureDate.TabIndex = 5;
            // 
            // returnDate
            // 
            this.returnDate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnDate.Location = new System.Drawing.Point(1232, 68);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(517, 50);
            this.returnDate.TabIndex = 6;
            // 
            // TravelApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2339, 1249);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.departureDate);
            this.Controls.Add(this.destinationComboBox);
            this.Controls.Add(this.originComboBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "TravelApp";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private ListBox listBox1;
        private ComboBox originComboBox;
        private ComboBox destinationComboBox;
        private DateTimePicker departureDate;
        private DateTimePicker returnDate;
    }
}