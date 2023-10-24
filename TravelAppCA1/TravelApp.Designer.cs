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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelApp));
            this.searchFlightButton = new System.Windows.Forms.Button();
            this.originComboBox = new System.Windows.Forms.ComboBox();
            this.destinationComboBox = new System.Windows.Forms.ComboBox();
            this.departureDatePicker = new System.Windows.Forms.DateTimePicker();
            this.numAdultsForm = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.currency = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numChildren = new System.Windows.Forms.Label();
            this.numChildrenForm = new System.Windows.Forms.NumericUpDown();
            this.travelClassGroupBox = new System.Windows.Forms.GroupBox();
            this.firstRadioButton = new System.Windows.Forms.RadioButton();
            this.businessRadioButton = new System.Windows.Forms.RadioButton();
            this.premiumEconomyRadioButton = new System.Windows.Forms.RadioButton();
            this.economyRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numAdults = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.departureDateLabel = new System.Windows.Forms.Label();
            this.originLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.flightsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flightDetailsPanel = new System.Windows.Forms.Panel();
            this.nonStopCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAdultsForm)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChildrenForm)).BeginInit();
            this.travelClassGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchFlightButton
            // 
            this.searchFlightButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchFlightButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.searchFlightButton.Location = new System.Drawing.Point(115, 1250);
            this.searchFlightButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.searchFlightButton.Name = "searchFlightButton";
            this.searchFlightButton.Size = new System.Drawing.Size(624, 84);
            this.searchFlightButton.TabIndex = 1;
            this.searchFlightButton.Text = "Search Flight";
            this.searchFlightButton.UseVisualStyleBackColor = true;
            this.searchFlightButton.Click += new System.EventHandler(this.searchFlightButton_Click);
            // 
            // originComboBox
            // 
            this.originComboBox.DropDownHeight = 600;
            this.originComboBox.DropDownWidth = 615;
            this.originComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.originComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.originComboBox.FormattingEnabled = true;
            this.originComboBox.IntegralHeight = false;
            this.originComboBox.ItemHeight = 45;
            this.originComboBox.Location = new System.Drawing.Point(115, 350);
            this.originComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.originComboBox.Name = "originComboBox";
            this.originComboBox.Size = new System.Drawing.Size(615, 53);
            this.originComboBox.TabIndex = 3;
            this.originComboBox.Text = "From";
            // 
            // destinationComboBox
            // 
            this.destinationComboBox.DropDownHeight = 600;
            this.destinationComboBox.DropDownWidth = 615;
            this.destinationComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.destinationComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.destinationComboBox.FormattingEnabled = true;
            this.destinationComboBox.IntegralHeight = false;
            this.destinationComboBox.ItemHeight = 45;
            this.destinationComboBox.Location = new System.Drawing.Point(115, 500);
            this.destinationComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.destinationComboBox.Name = "destinationComboBox";
            this.destinationComboBox.Size = new System.Drawing.Size(615, 53);
            this.destinationComboBox.TabIndex = 4;
            this.destinationComboBox.Text = "To";
            // 
            // departureDatePicker
            // 
            this.departureDatePicker.CalendarFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departureDatePicker.CustomFormat = "";
            this.departureDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departureDatePicker.Location = new System.Drawing.Point(115, 660);
            this.departureDatePicker.MinDate = new System.DateTime(2023, 10, 23, 21, 41, 18, 0);
            this.departureDatePicker.Name = "departureDatePicker";
            this.departureDatePicker.Size = new System.Drawing.Size(615, 50);
            this.departureDatePicker.TabIndex = 5;
            this.departureDatePicker.Value = new System.DateTime(2023, 10, 23, 21, 41, 18, 0);
            // 
            // numAdultsForm
            // 
            this.numAdultsForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numAdultsForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numAdultsForm.Location = new System.Drawing.Point(115, 823);
            this.numAdultsForm.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numAdultsForm.Name = "numAdultsForm";
            this.numAdultsForm.Size = new System.Drawing.Size(117, 46);
            this.numAdultsForm.TabIndex = 7;
            this.numAdultsForm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.nonStopCheckBox);
            this.panel1.Controls.Add(this.currencyComboBox);
            this.panel1.Controls.Add(this.currency);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.numChildren);
            this.panel1.Controls.Add(this.numChildrenForm);
            this.panel1.Controls.Add(this.travelClassGroupBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.numAdults);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.departureDateLabel);
            this.panel1.Controls.Add(this.originLabel);
            this.panel1.Controls.Add(this.searchFlightButton);
            this.panel1.Controls.Add(this.destinationLabel);
            this.panel1.Controls.Add(this.numAdultsForm);
            this.panel1.Controls.Add(this.originComboBox);
            this.panel1.Controls.Add(this.destinationComboBox);
            this.panel1.Controls.Add(this.departureDatePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 1398);
            this.panel1.TabIndex = 8;
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.DropDownHeight = 600;
            this.currencyComboBox.DropDownWidth = 600;
            this.currencyComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.IntegralHeight = false;
            this.currencyComboBox.Location = new System.Drawing.Point(510, 819);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(220, 53);
            this.currencyComboBox.TabIndex = 24;
            // 
            // currency
            // 
            this.currency.AutoSize = true;
            this.currency.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currency.ForeColor = System.Drawing.Color.Snow;
            this.currency.Location = new System.Drawing.Point(510, 763);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(153, 45);
            this.currency.TabIndex = 23;
            this.currency.Text = "Currency";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Location = new System.Drawing.Point(461, 782);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 90);
            this.panel2.TabIndex = 22;
            // 
            // numChildren
            // 
            this.numChildren.AutoSize = true;
            this.numChildren.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numChildren.ForeColor = System.Drawing.Color.Snow;
            this.numChildren.Location = new System.Drawing.Point(279, 763);
            this.numChildren.Name = "numChildren";
            this.numChildren.Size = new System.Drawing.Size(146, 45);
            this.numChildren.TabIndex = 21;
            this.numChildren.Text = "Children";
            // 
            // numChildrenForm
            // 
            this.numChildrenForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numChildrenForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numChildrenForm.Location = new System.Drawing.Point(284, 823);
            this.numChildrenForm.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numChildrenForm.Name = "numChildrenForm";
            this.numChildrenForm.Size = new System.Drawing.Size(117, 46);
            this.numChildrenForm.TabIndex = 20;
            // 
            // travelClassGroupBox
            // 
            this.travelClassGroupBox.Controls.Add(this.firstRadioButton);
            this.travelClassGroupBox.Controls.Add(this.businessRadioButton);
            this.travelClassGroupBox.Controls.Add(this.premiumEconomyRadioButton);
            this.travelClassGroupBox.Controls.Add(this.economyRadioButton);
            this.travelClassGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.travelClassGroupBox.ForeColor = System.Drawing.Color.Snow;
            this.travelClassGroupBox.Location = new System.Drawing.Point(115, 914);
            this.travelClassGroupBox.Name = "travelClassGroupBox";
            this.travelClassGroupBox.Size = new System.Drawing.Size(624, 187);
            this.travelClassGroupBox.TabIndex = 19;
            this.travelClassGroupBox.TabStop = false;
            this.travelClassGroupBox.Text = "Travel Class";
            // 
            // firstRadioButton
            // 
            this.firstRadioButton.AutoSize = true;
            this.firstRadioButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstRadioButton.Location = new System.Drawing.Point(379, 121);
            this.firstRadioButton.Name = "firstRadioButton";
            this.firstRadioButton.Size = new System.Drawing.Size(97, 41);
            this.firstRadioButton.TabIndex = 3;
            this.firstRadioButton.TabStop = true;
            this.firstRadioButton.Text = "First";
            this.firstRadioButton.UseVisualStyleBackColor = true;
            // 
            // businessRadioButton
            // 
            this.businessRadioButton.AutoSize = true;
            this.businessRadioButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.businessRadioButton.Location = new System.Drawing.Point(379, 61);
            this.businessRadioButton.Name = "businessRadioButton";
            this.businessRadioButton.Size = new System.Drawing.Size(147, 41);
            this.businessRadioButton.TabIndex = 2;
            this.businessRadioButton.TabStop = true;
            this.businessRadioButton.Text = "Business";
            this.businessRadioButton.UseVisualStyleBackColor = true;
            // 
            // premiumEconomyRadioButton
            // 
            this.premiumEconomyRadioButton.AutoSize = true;
            this.premiumEconomyRadioButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.premiumEconomyRadioButton.Location = new System.Drawing.Point(40, 121);
            this.premiumEconomyRadioButton.Name = "premiumEconomyRadioButton";
            this.premiumEconomyRadioButton.Size = new System.Drawing.Size(270, 41);
            this.premiumEconomyRadioButton.TabIndex = 1;
            this.premiumEconomyRadioButton.TabStop = true;
            this.premiumEconomyRadioButton.Text = "Premium Economy";
            this.premiumEconomyRadioButton.UseVisualStyleBackColor = true;
            // 
            // economyRadioButton
            // 
            this.economyRadioButton.AutoSize = true;
            this.economyRadioButton.Checked = true;
            this.economyRadioButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.economyRadioButton.Location = new System.Drawing.Point(40, 61);
            this.economyRadioButton.Name = "economyRadioButton";
            this.economyRadioButton.Size = new System.Drawing.Size(157, 41);
            this.economyRadioButton.TabIndex = 0;
            this.economyRadioButton.TabStop = true;
            this.economyRadioButton.Text = "Economy";
            this.economyRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(144, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // numAdults
            // 
            this.numAdults.AutoSize = true;
            this.numAdults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numAdults.ForeColor = System.Drawing.Color.Snow;
            this.numAdults.Location = new System.Drawing.Point(115, 763);
            this.numAdults.Name = "numAdults";
            this.numAdults.Size = new System.Drawing.Size(117, 45);
            this.numAdults.TabIndex = 15;
            this.numAdults.Text = "Adults";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Black", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(318, 95);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(372, 100);
            this.title.TabIndex = 12;
            this.title.Text = "JetSetGo";
            // 
            // departureDateLabel
            // 
            this.departureDateLabel.AutoSize = true;
            this.departureDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departureDateLabel.ForeColor = System.Drawing.Color.Snow;
            this.departureDateLabel.Location = new System.Drawing.Point(115, 595);
            this.departureDateLabel.Name = "departureDateLabel";
            this.departureDateLabel.Size = new System.Drawing.Size(252, 45);
            this.departureDateLabel.TabIndex = 10;
            this.departureDateLabel.Text = "Departure Date";
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.originLabel.ForeColor = System.Drawing.Color.Snow;
            this.originLabel.Location = new System.Drawing.Point(115, 290);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(114, 45);
            this.originLabel.TabIndex = 9;
            this.originLabel.Text = "Origin";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.destinationLabel.ForeColor = System.Drawing.Color.Snow;
            this.destinationLabel.Location = new System.Drawing.Point(115, 440);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(192, 45);
            this.destinationLabel.TabIndex = 8;
            this.destinationLabel.Text = "Destination";
            // 
            // flightsFlowLayoutPanel
            // 
            this.flightsFlowLayoutPanel.AutoScroll = true;
            this.flightsFlowLayoutPanel.Location = new System.Drawing.Point(893, 15);
            this.flightsFlowLayoutPanel.Name = "flightsFlowLayoutPanel";
            this.flightsFlowLayoutPanel.Size = new System.Drawing.Size(1182, 1380);
            this.flightsFlowLayoutPanel.TabIndex = 9;
            // 
            // flightDetailsPanel
            // 
            this.flightDetailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flightDetailsPanel.Location = new System.Drawing.Point(900, 12);
            this.flightDetailsPanel.Name = "flightDetailsPanel";
            this.flightDetailsPanel.Size = new System.Drawing.Size(1178, 1386);
            this.flightDetailsPanel.TabIndex = 10;
            this.flightDetailsPanel.Visible = false;
            // 
            // nonStopCheckBox
            // 
            this.nonStopCheckBox.AutoSize = true;
            this.nonStopCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nonStopCheckBox.ForeColor = System.Drawing.Color.Snow;
            this.nonStopCheckBox.Location = new System.Drawing.Point(318, 1142);
            this.nonStopCheckBox.Name = "nonStopCheckBox";
            this.nonStopCheckBox.Size = new System.Drawing.Size(185, 49);
            this.nonStopCheckBox.TabIndex = 25;
            this.nonStopCheckBox.Text = "Non stop";
            this.nonStopCheckBox.UseVisualStyleBackColor = true;
            // 
            // TravelApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2094, 1398);
            this.Controls.Add(this.flightsFlowLayoutPanel);
            this.Controls.Add(this.flightDetailsPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TravelApp";
            this.Text = "Travel App";
            ((System.ComponentModel.ISupportInitialize)(this.numAdultsForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChildrenForm)).EndInit();
            this.travelClassGroupBox.ResumeLayout(false);
            this.travelClassGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button searchFlightButton;
        private ComboBox originComboBox;
        private ComboBox destinationComboBox;
        private DateTimePicker departureDatePicker;
        private NumericUpDown numAdultsForm;
        private Panel panel1;
        private Label destinationLabel;
        private Label originLabel;
        private Label departureDateLabel;
        private Label title;
        private Label numAdults;
        private PictureBox pictureBox1;
        private GroupBox travelClassGroupBox;
        private RadioButton firstRadioButton;
        private RadioButton businessRadioButton;
        private RadioButton premiumEconomyRadioButton;
        private RadioButton economyRadioButton;
        public FlowLayoutPanel flightsFlowLayoutPanel;
        private Panel flightDetailsPanel;
        private Label numChildren;
        private NumericUpDown numChildrenForm;
        private ComboBox currencyComboBox;
        private Label currency;
        private Panel panel2;
        private CheckBox nonStopCheckBox;
    }
}