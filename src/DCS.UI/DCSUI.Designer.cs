namespace DCS.UI
{
    partial class DCSUI
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
            this.btnScan = new System.Windows.Forms.Button();
            this.lblBoardingPassString = new System.Windows.Forms.Label();
            this.txtBoardingPassString = new System.Windows.Forms.TextBox();
            this.pnlPNR = new System.Windows.Forms.Panel();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.lblBags = new System.Windows.Forms.Label();
            this.nmrBags = new System.Windows.Forms.NumericUpDown();
            this.txtAllowance = new System.Windows.Forms.TextBox();
            this.txtCheckInStatus = new System.Windows.Forms.TextBox();
            this.txtTravelClass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAllowance = new System.Windows.Forms.Label();
            this.lblIsCheckInStatus = new System.Windows.Forms.Label();
            this.lblTravelClass = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlFlights = new System.Windows.Forms.Panel();
            this.gvFlights = new System.Windows.Forms.DataGridView();
            this.pnlPNR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBags)).BeginInit();
            this.pnlFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(181, 97);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lblBoardingPassString
            // 
            this.lblBoardingPassString.AutoSize = true;
            this.lblBoardingPassString.Location = new System.Drawing.Point(60, 30);
            this.lblBoardingPassString.Name = "lblBoardingPassString";
            this.lblBoardingPassString.Size = new System.Drawing.Size(105, 13);
            this.lblBoardingPassString.TabIndex = 1;
            this.lblBoardingPassString.Text = "Boarding Pass String";
            // 
            // txtBoardingPassString
            // 
            this.txtBoardingPassString.Location = new System.Drawing.Point(181, 30);
            this.txtBoardingPassString.Multiline = true;
            this.txtBoardingPassString.Name = "txtBoardingPassString";
            this.txtBoardingPassString.Size = new System.Drawing.Size(486, 47);
            this.txtBoardingPassString.TabIndex = 2;
            this.txtBoardingPassString.Text = "M1DOE/JOHNMR           2LMWIN AMSJFKKL 0463 123Y007F0500 16C5320  8123BXH        " +
    "                                2A             00KL                         0647" +
    "352398";
            // 
            // pnlPNR
            // 
            this.pnlPNR.Controls.Add(this.btnCheckIn);
            this.pnlPNR.Controls.Add(this.lblBags);
            this.pnlPNR.Controls.Add(this.nmrBags);
            this.pnlPNR.Controls.Add(this.txtAllowance);
            this.pnlPNR.Controls.Add(this.txtCheckInStatus);
            this.pnlPNR.Controls.Add(this.txtTravelClass);
            this.pnlPNR.Controls.Add(this.txtName);
            this.pnlPNR.Controls.Add(this.lblAllowance);
            this.pnlPNR.Controls.Add(this.lblIsCheckInStatus);
            this.pnlPNR.Controls.Add(this.lblTravelClass);
            this.pnlPNR.Controls.Add(this.lblName);
            this.pnlPNR.Location = new System.Drawing.Point(63, 247);
            this.pnlPNR.Name = "pnlPNR";
            this.pnlPNR.Size = new System.Drawing.Size(604, 75);
            this.pnlPNR.TabIndex = 3;
            this.pnlPNR.Visible = false;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(491, 45);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(75, 23);
            this.btnCheckIn.TabIndex = 5;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // lblBags
            // 
            this.lblBags.AutoSize = true;
            this.lblBags.Location = new System.Drawing.Point(3, 47);
            this.lblBags.Name = "lblBags";
            this.lblBags.Size = new System.Drawing.Size(31, 13);
            this.lblBags.TabIndex = 9;
            this.lblBags.Text = "Bags";
            // 
            // nmrBags
            // 
            this.nmrBags.Location = new System.Drawing.Point(44, 45);
            this.nmrBags.Name = "nmrBags";
            this.nmrBags.Size = new System.Drawing.Size(58, 20);
            this.nmrBags.TabIndex = 2;
            // 
            // txtAllowance
            // 
            this.txtAllowance.Location = new System.Drawing.Point(230, 44);
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.Size = new System.Drawing.Size(36, 20);
            this.txtAllowance.TabIndex = 5;
            // 
            // txtCheckInStatus
            // 
            this.txtCheckInStatus.Enabled = false;
            this.txtCheckInStatus.Location = new System.Drawing.Point(345, 11);
            this.txtCheckInStatus.Name = "txtCheckInStatus";
            this.txtCheckInStatus.Size = new System.Drawing.Size(100, 20);
            this.txtCheckInStatus.TabIndex = 6;
            // 
            // txtTravelClass
            // 
            this.txtTravelClass.Enabled = false;
            this.txtTravelClass.Location = new System.Drawing.Point(522, 11);
            this.txtTravelClass.Name = "txtTravelClass";
            this.txtTravelClass.Size = new System.Drawing.Size(44, 20);
            this.txtTravelClass.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(44, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 20);
            this.txtName.TabIndex = 8;
            // 
            // lblAllowance
            // 
            this.lblAllowance.AutoSize = true;
            this.lblAllowance.Location = new System.Drawing.Point(131, 47);
            this.lblAllowance.Name = "lblAllowance";
            this.lblAllowance.Size = new System.Drawing.Size(93, 13);
            this.lblAllowance.TabIndex = 3;
            this.lblAllowance.Text = "Weight Allowance";
            // 
            // lblIsCheckInStatus
            // 
            this.lblIsCheckInStatus.AutoSize = true;
            this.lblIsCheckInStatus.Location = new System.Drawing.Point(256, 13);
            this.lblIsCheckInStatus.Name = "lblIsCheckInStatus";
            this.lblIsCheckInStatus.Size = new System.Drawing.Size(83, 13);
            this.lblIsCheckInStatus.TabIndex = 2;
            this.lblIsCheckInStatus.Text = "Check In Status";
            // 
            // lblTravelClass
            // 
            this.lblTravelClass.AutoSize = true;
            this.lblTravelClass.Location = new System.Drawing.Point(455, 13);
            this.lblTravelClass.Name = "lblTravelClass";
            this.lblTravelClass.Size = new System.Drawing.Size(65, 13);
            this.lblTravelClass.TabIndex = 1;
            this.lblTravelClass.Text = "Travel Class";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // pnlFlights
            // 
            this.pnlFlights.Controls.Add(this.gvFlights);
            this.pnlFlights.Location = new System.Drawing.Point(63, 141);
            this.pnlFlights.Name = "pnlFlights";
            this.pnlFlights.Size = new System.Drawing.Size(604, 100);
            this.pnlFlights.TabIndex = 4;
            // 
            // gvFlights
            // 
            this.gvFlights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFlights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvFlights.Location = new System.Drawing.Point(0, 0);
            this.gvFlights.Name = "gvFlights";
            this.gvFlights.Size = new System.Drawing.Size(604, 100);
            this.gvFlights.TabIndex = 0;
            // 
            // DCSUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.pnlFlights);
            this.Controls.Add(this.pnlPNR);
            this.Controls.Add(this.txtBoardingPassString);
            this.Controls.Add(this.lblBoardingPassString);
            this.Controls.Add(this.btnScan);
            this.Name = "DCSUI";
            this.Text = "DCS.UI";
            this.pnlPNR.ResumeLayout(false);
            this.pnlPNR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBags)).EndInit();
            this.pnlFlights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label lblBoardingPassString;
        private System.Windows.Forms.TextBox txtBoardingPassString;
        private System.Windows.Forms.Panel pnlPNR;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAllowance;
        private System.Windows.Forms.Label lblIsCheckInStatus;
        private System.Windows.Forms.Label lblTravelClass;
        private System.Windows.Forms.TextBox txtAllowance;
        private System.Windows.Forms.TextBox txtCheckInStatus;
        private System.Windows.Forms.TextBox txtTravelClass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel pnlFlights;
        private System.Windows.Forms.DataGridView gvFlights;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label lblBags;
        private System.Windows.Forms.NumericUpDown nmrBags;
    }
}

