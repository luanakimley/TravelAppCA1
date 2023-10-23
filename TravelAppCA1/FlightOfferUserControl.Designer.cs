namespace TravelAppCA1
{
    partial class FlightOfferUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightOfferUserControl));
            this.departureTime = new System.Windows.Forms.Label();
            this.arrivalTime = new System.Windows.Forms.Label();
            this.numStops = new System.Windows.Forms.Label();
            this.flightDuration = new System.Windows.Forms.Label();
            this.originAirport = new System.Windows.Forms.Label();
            this.destinationAirport = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flightPrice = new System.Windows.Forms.Label();
            this.currencyLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.travelClassLabel = new System.Windows.Forms.Label();
            this.flightDetailsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // departureTime
            // 
            this.departureTime.AutoSize = true;
            this.departureTime.Font = new System.Drawing.Font("Segoe UI", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departureTime.Location = new System.Drawing.Point(31, 74);
            this.departureTime.Name = "departureTime";
            this.departureTime.Size = new System.Drawing.Size(185, 78);
            this.departureTime.TabIndex = 0;
            this.departureTime.Text = "18:45";
            // 
            // arrivalTime
            // 
            this.arrivalTime.AutoSize = true;
            this.arrivalTime.Font = new System.Drawing.Font("Segoe UI", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.arrivalTime.Location = new System.Drawing.Point(443, 74);
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Size = new System.Drawing.Size(185, 78);
            this.arrivalTime.TabIndex = 1;
            this.arrivalTime.Text = "06:45";
            // 
            // numStops
            // 
            this.numStops.AutoSize = true;
            this.numStops.Location = new System.Drawing.Point(287, 191);
            this.numStops.Name = "numStops";
            this.numStops.Size = new System.Drawing.Size(80, 32);
            this.numStops.TabIndex = 2;
            this.numStops.Text = "1 stop";
            this.numStops.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flightDuration
            // 
            this.flightDuration.AutoSize = true;
            this.flightDuration.Location = new System.Drawing.Point(276, 233);
            this.flightDuration.Name = "flightDuration";
            this.flightDuration.Size = new System.Drawing.Size(108, 32);
            this.flightDuration.TabIndex = 3;
            this.flightDuration.Text = "18h 45m";
            this.flightDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // originAirport
            // 
            this.originAirport.AutoSize = true;
            this.originAirport.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.originAirport.Location = new System.Drawing.Point(78, 160);
            this.originAirport.Name = "originAirport";
            this.originAirport.Size = new System.Drawing.Size(94, 50);
            this.originAirport.TabIndex = 4;
            this.originAirport.Text = "CGK";
            // 
            // destinationAirport
            // 
            this.destinationAirport.AutoSize = true;
            this.destinationAirport.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.destinationAirport.Location = new System.Drawing.Point(491, 160);
            this.destinationAirport.Name = "destinationAirport";
            this.destinationAirport.Size = new System.Drawing.Size(100, 50);
            this.destinationAirport.TabIndex = 5;
            this.destinationAirport.Text = "DUB";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(675, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 237);
            this.panel1.TabIndex = 6;
            // 
            // flightPrice
            // 
            this.flightPrice.AutoEllipsis = true;
            this.flightPrice.AutoSize = true;
            this.flightPrice.Font = new System.Drawing.Font("Segoe UI", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.flightPrice.Location = new System.Drawing.Point(800, 123);
            this.flightPrice.Name = "flightPrice";
            this.flightPrice.Size = new System.Drawing.Size(169, 78);
            this.flightPrice.TabIndex = 7;
            this.flightPrice.Text = "1000";
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currencyLabel.Location = new System.Drawing.Point(727, 147);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(67, 37);
            this.currencyLabel.TabIndex = 8;
            this.currencyLabel.Text = "EUR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(256, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // travelClassLabel
            // 
            this.travelClassLabel.AutoSize = true;
            this.travelClassLabel.Location = new System.Drawing.Point(737, 60);
            this.travelClassLabel.Name = "travelClassLabel";
            this.travelClassLabel.Size = new System.Drawing.Size(215, 32);
            this.travelClassLabel.TabIndex = 10;
            this.travelClassLabel.Text = "Premium Economy";
            this.travelClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flightDetailsButton
            // 
            this.flightDetailsButton.BackColor = System.Drawing.Color.SteelBlue;
            this.flightDetailsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.flightDetailsButton.ForeColor = System.Drawing.Color.Snow;
            this.flightDetailsButton.Location = new System.Drawing.Point(810, 233);
            this.flightDetailsButton.Name = "flightDetailsButton";
            this.flightDetailsButton.Size = new System.Drawing.Size(197, 46);
            this.flightDetailsButton.TabIndex = 11;
            this.flightDetailsButton.Text = "Flight Details";
            this.flightDetailsButton.UseVisualStyleBackColor = false;
            // 
            // FlightOfferUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flightDetailsButton);
            this.Controls.Add(this.travelClassLabel);
            this.Controls.Add(this.currencyLabel);
            this.Controls.Add(this.flightPrice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.destinationAirport);
            this.Controls.Add(this.originAirport);
            this.Controls.Add(this.flightDuration);
            this.Controls.Add(this.numStops);
            this.Controls.Add(this.arrivalTime);
            this.Controls.Add(this.departureTime);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FlightOfferUserControl";
            this.Size = new System.Drawing.Size(1028, 300);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        public Label departureTime;
        public Label arrivalTime;
        public Label numStops;
        public Label flightDuration;
        public Label originAirport;
        public Label destinationAirport;
        public Label flightPrice;
        public Label currencyLabel;
        private PictureBox pictureBox1;
        public Label travelClassLabel;
        public Button flightDetailsButton;
    }
}
