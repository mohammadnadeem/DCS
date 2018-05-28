using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DCS.Core;
using DCS.Core.PassengerService;
using log4net;
using log4net.Config;

namespace DCS.UI
{
    public partial class DCSUI : Form
    {
        private FindPassengerResult currentFindPassengerResult;
        public DCSUI()
        {
            InitializeComponent();
            pnlPNR.Visible = false;
            pnlFlights.Visible = false;
            XmlConfigurator.Configure(); // enable logging
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInManager cm = new CheckInManager();

                currentFindPassengerResult = cm.FindPassenger(txtBoardingPassString.Text);
                if (currentFindPassengerResult.IsSuccess)
                    UpdatePNROnUI(currentFindPassengerResult);
                else
                    MessageBox.Show(currentFindPassengerResult.Error, "Passenger Service Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                // use online parser if passenger service is down
                // this can be used only to see boarding pass data
                // for operations lile checkin, passenger service must work
                var confirmResult = MessageBox.Show("Passenger service failed to scan the boarding pass due to the error " + ex.Message + Environment.NewLine +
                    "Do you want to use the online parser to parse the boarding pass?", "Confirm!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    currentFindPassengerResult = BoardingPassParsor.ParseBoardingString(txtBoardingPassString.Text);
                    if (currentFindPassengerResult.IsSuccess)
                        UpdatePNROnUI(currentFindPassengerResult);
                    currentFindPassengerResult.IsSuccess = false; // set success to false to make sure checkin is not allowed
                }
            }
        }

        private void UpdatePNROnUI(FindPassengerResult findPassengerResult)
        {   
            // Load Passenger Information
            txtName.Text = findPassengerResult.PassengerNameRecord.FirstName + " " + findPassengerResult.PassengerNameRecord.LastName;
            txtTravelClass.Text = findPassengerResult.PassengerNameRecord.TravelClass;
            txtCheckInStatus.Text = findPassengerResult.PassengerNameRecord.CheckedIn ? "Yes" : "No";
            txtAllowance.Text = findPassengerResult.PassengerNameRecord.Allowance.ToString();
            if (findPassengerResult.PassengerNameRecord.Allowance > 0)
                nmrBags.Value = 1;
            else
                nmrBags.Value = 0;

            // Load flight information
            gvFlights.DataSource = findPassengerResult.PassengerNameRecord.Flights;

            gvFlights.Enabled = false;
            pnlPNR.Visible = true;
            pnlFlights.Visible = true;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if(!currentFindPassengerResult.IsSuccess)
            {
                MessageBox.Show("There were errors during scanning boarding pass, try scanning boarding pass again first.", "Checkin Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (currentFindPassengerResult.PassengerNameRecord.CheckedIn
                || txtCheckInStatus.Text.Equals("YES")
                )
            {
                MessageBox.Show("Passenger already checked in.", "Checkin Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            CheckInManager cm = new CheckInManager();
            var checkInResult = cm.CheckIn(currentFindPassengerResult.PassengerNameRecord.Id, Convert.ToDecimal(txtAllowance.Text));

            if (checkInResult.IsSuccess)
            {
                MessageBox.Show("Passenger checked in successfully!", "Checkin Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCheckInStatus.Text = "YES";
            }
            else
                MessageBox.Show(checkInResult.Error, "Checkin Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
