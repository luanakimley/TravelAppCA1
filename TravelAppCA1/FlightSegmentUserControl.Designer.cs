namespace TravelAppCA1
{
    partial class FlightSegmentUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightSegmentUserControl));
            this.destinationAirport = new System.Windows.Forms.Label();
            this.originAirport = new System.Windows.Forms.Label();
            this.flightDuration = new System.Windows.Forms.Label();
            this.airlineNumber = new System.Windows.Forms.Label();
            this.arrivalTime = new System.Windows.Forms.Label();
            this.departureTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.originTerminal = new System.Windows.Forms.Label();
            this.destinationTerminal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // destinationAirport
            // 
            this.destinationAirport.AutoSize = true;
            this.destinationAirport.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.destinationAirport.Location = new System.Drawing.Point(659, 148);
            this.destinationAirport.Name = "destinationAirport";
            this.destinationAirport.Size = new System.Drawing.Size(100, 50);
            this.destinationAirport.TabIndex = 15;
            this.destinationAirport.Text = "DUB";
            // 
            // originAirport
            // 
            this.originAirport.AutoSize = true;
            this.originAirport.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.originAirport.Location = new System.Drawing.Point(246, 148);
            this.originAirport.Name = "originAirport";
            this.originAirport.Size = new System.Drawing.Size(94, 50);
            this.originAirport.TabIndex = 14;
            this.originAirport.Text = "CGK";
            // 
            // flightDuration
            // 
            this.flightDuration.AutoSize = true;
            this.flightDuration.Location = new System.Drawing.Point(444, 221);
            this.flightDuration.Name = "flightDuration";
            this.flightDuration.Size = new System.Drawing.Size(108, 32);
            this.flightDuration.TabIndex = 13;
            this.flightDuration.Text = "18h 45m";
            this.flightDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // airlineNumber
            // 
            this.airlineNumber.AutoSize = true;
            this.airlineNumber.Location = new System.Drawing.Point(455, 179);
            this.airlineNumber.Name = "airlineNumber";
            this.airlineNumber.Size = new System.Drawing.Size(84, 32);
            this.airlineNumber.TabIndex = 12;
            this.airlineNumber.Text = "GA778";
            this.airlineNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrivalTime
            // 
            this.arrivalTime.AutoSize = true;
            this.arrivalTime.Font = new System.Drawing.Font("Segoe UI", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.arrivalTime.Location = new System.Drawing.Point(611, 62);
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Size = new System.Drawing.Size(185, 78);
            this.arrivalTime.TabIndex = 11;
            this.arrivalTime.Text = "06:45";
            // 
            // departureTime
            // 
            this.departureTime.AutoSize = true;
            this.departureTime.Font = new System.Drawing.Font("Segoe UI", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departureTime.Location = new System.Drawing.Point(199, 62);
            this.departureTime.Name = "departureTime";
            this.departureTime.Size = new System.Drawing.Size(185, 78);
            this.departureTime.TabIndex = 10;
            this.departureTime.Text = "18:45";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(424, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // originTerminal
            // 
            this.originTerminal.AutoSize = true;
            this.originTerminal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.originTerminal.Location = new System.Drawing.Point(208, 198);
            this.originTerminal.Name = "originTerminal";
            this.originTerminal.Size = new System.Drawing.Size(176, 45);
            this.originTerminal.TabIndex = 17;
            this.originTerminal.Text = "Terminal 3";
            // 
            // destinationTerminal
            // 
            this.destinationTerminal.AutoSize = true;
            this.destinationTerminal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.destinationTerminal.Location = new System.Drawing.Point(620, 198);
            this.destinationTerminal.Name = "destinationTerminal";
            this.destinationTerminal.Size = new System.Drawing.Size(176, 45);
            this.destinationTerminal.TabIndex = 18;
            this.destinationTerminal.Text = "Terminal 2";
            // 
            // FlightSegmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.destinationTerminal);
            this.Controls.Add(this.originTerminal);
            this.Controls.Add(this.destinationAirport);
            this.Controls.Add(this.originAirport);
            this.Controls.Add(this.flightDuration);
            this.Controls.Add(this.airlineNumber);
            this.Controls.Add(this.arrivalTime);
            this.Controls.Add(this.departureTime);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FlightSegmentUserControl";
            this.Size = new System.Drawing.Size(1023, 320);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label destinationAirport;
        public Label originAirport;
        public Label flightDuration;
        public Label airlineNumber;
        public Label arrivalTime;
        public Label departureTime;
        private PictureBox pictureBox1;
        public Label originTerminal;
        public Label destinationTerminal;
    }
}
