using System;
using System.Windows.Forms;

/*
 * Zachary Betters
 * CIS 209
 * Sept 21, 2016
 * Hospital Charges
 * This program will calculate user input with methods 
 */

namespace HospitalCharges {
    public partial class Form1 : Form {

        public Form1() { InitializeComponent(); }
        private void btnExit_Click(object sender, EventArgs e) { Close(); }

        //this method calculates charge for days and returns it
        public double CalcStayCharges(double days) {
            double StayCharge = 350 * days;
            return StayCharge;
        }

        //this method adds all misc prices and returns it 
        public double CalcMiscCharges(double med, double surg, 
            double lab, double rehab) {
            return med + surg + lab + rehab;
        }

        //this method calculates total and returns it 
        public double CalcTotalCharges(double MiscTotal, double StayCharge) {
            return MiscTotal + StayCharge;
        }

        public bool isNegative() {
            if (double.Parse(tbDays.Text) < 0 || double.Parse(tbMed.Text) < 0
                || double.Parse(tbSurg.Text) < 0 || double.Parse(tbLab.Text) < 0
                || double.Parse(tbRehab.Text) < 0)
                return false;
            else
                return true;
        } 

        private void btnCalc_Click(object sender, EventArgs e) {

            if (!isNegative()) {
                MessageBox.Show("Negative numbers not accepted!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else {
                           
                //if any variables have strings...
                try {

                    //all variables are found in the textboxes 
                    double NumDays = double.Parse(tbDays.Text);
                    double MedCharge = double.Parse(tbMed.Text);
                    double SurgCharge = double.Parse(tbSurg.Text);
                    double LabCharge = double.Parse(tbLab.Text);
                    double RehabCharge = double.Parse(tbRehab.Text);

                    double MiscTotal = CalcMiscCharges(MedCharge, 
                        SurgCharge, LabCharge, RehabCharge);
                    double StayCharge = CalcStayCharges(NumDays);
                    double Total = CalcTotalCharges(StayCharge, MiscTotal);

                    //variable total is outputed to tbTotal textbox
                    tbTotal.Text = "$" + Total.ToString("F");
                }

                //...show error message
                catch {
                   MessageBox.Show( "One or more of the fields" +
                        " contains incorrect input!", "Error!", MessageBoxButtons.OK 
                         , MessageBoxIcon.Warning);
                }
            }
        }
    }
}