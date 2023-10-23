namespace TravelAppCA1
{
    partial class FlightDetailsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightDetailsUserControl));
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceValue = new System.Windows.Forms.Label();
            this.travelClassValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.currencyValue = new System.Windows.Forms.Label();
            this.backToFlightsButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flightSegmentsflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.backToFlightsButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.priceLabel.Location = new System.Drawing.Point(2, 10);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(91, 45);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price";
            // 
            // priceValue
            // 
            this.priceValue.AutoSize = true;
            this.priceValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.priceValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceValue.Location = new System.Drawing.Point(542, 0);
            this.priceValue.Name = "priceValue";
            this.priceValue.Size = new System.Drawing.Size(140, 65);
            this.priceValue.TabIndex = 4;
            this.priceValue.Text = "1000";
            this.priceValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // travelClassValue
            // 
            this.travelClassValue.AutoSize = true;
            this.travelClassValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.travelClassValue.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.travelClassValue.Location = new System.Drawing.Point(458, 0);
            this.travelClassValue.Name = "travelClassValue";
            this.travelClassValue.Size = new System.Drawing.Size(224, 59);
            this.travelClassValue.TabIndex = 7;
            this.travelClassValue.Text = "First Class";
            this.travelClassValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(15, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 45);
            this.label4.TabIndex = 6;
            this.label4.Text = "Travel class";
            // 
            // currencyValue
            // 
            this.currencyValue.AutoSize = true;
            this.currencyValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currencyValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.currencyValue.Location = new System.Drawing.Point(85, 10);
            this.currencyValue.Name = "currencyValue";
            this.currencyValue.Size = new System.Drawing.Size(102, 45);
            this.currencyValue.TabIndex = 5;
            this.currencyValue.Text = "(EUR)";
            this.currencyValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // backToFlightsButton
            // 
            this.backToFlightsButton.Image = ((System.Drawing.Image)(resources.GetObject("backToFlightsButton.Image")));
            this.backToFlightsButton.Location = new System.Drawing.Point(38, 27);
            this.backToFlightsButton.Name = "backToFlightsButton";
            this.backToFlightsButton.Size = new System.Drawing.Size(73, 64);
            this.backToFlightsButton.TabIndex = 8;
            this.backToFlightsButton.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.travelClassValue);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(202, 1074);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 63);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.currencyValue);
            this.panel2.Controls.Add(this.priceLabel);
            this.panel2.Controls.Add(this.priceValue);
            this.panel2.Location = new System.Drawing.Point(202, 1163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 64);
            this.panel2.TabIndex = 10;
            // 
            // flightSegmentsflowLayoutPanel
            // 
            this.flightSegmentsflowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flightSegmentsflowLayoutPanel.AutoScroll = true;
            this.flightSegmentsflowLayoutPanel.Location = new System.Drawing.Point(3, 97);
            this.flightSegmentsflowLayoutPanel.Name = "flightSegmentsflowLayoutPanel";
            this.flightSegmentsflowLayoutPanel.Size = new System.Drawing.Size(1094, 906);
            this.flightSegmentsflowLayoutPanel.TabIndex = 0;
            // 
            // FlightDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backToFlightsButton);
            this.Controls.Add(this.flightSegmentsflowLayoutPanel);
            this.Name = "FlightDetailsUserControl";
            this.Size = new System.Drawing.Size(1100, 1297);
            ((System.ComponentModel.ISupportInitialize)(this.backToFlightsButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label priceLabel;
        private Label label4;
        private Label currencyValue;
        public PictureBox backToFlightsButton;
        public Label priceValue;
        public Label travelClassValue;
        private Panel panel1;
        private Panel panel2;
        public FlowLayoutPanel flightSegmentsflowLayoutPanel;
    }
}
