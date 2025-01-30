using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaidTravelAgencyManagmentSystem
{
    public partial class Form1 : Form
    {
        MainClass main = new MainClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkAirportTax.Checked = false;
            chkAirMiles.Checked = false;
            chkExtLuggge.Checked = false;
            chkTravelInsurance.Checked = false;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtReceipt.Clear();
            txtAddres.Clear();
            txtEmail.Clear();
            txtFristname.Clear();
            txtPostCode.Clear();
            txtSurname.Clear();
            txtTalephone.Clear();


            lblsubtotal.Text = " ";
            lblTax.Text = " ";
            lblTotal.Text = " ";


            cmbAccommodation.Text = " None";
            cmbDeparture.Text = "None ";
            cmbDestination.Text = "None  ";


            chkAirMiles.Checked = false;
            chkAirportTax.Checked = false;
            chkExtLuggge.Checked = false;
            chkTravelInsurance.Checked = false;
            chkSpecialNEed.Checked = false;




            chkAdult.Checked = false;
            chkReturn.Checked = false;
            chkSingle.Checked = false;
            chkChild.Checked = false;






            rbStandard.Checked = false;
            rbFristClass.Checked = false;
            rbEconomy.Checked = false;
        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to Exit", " Said Travel Agency maanagment",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void chkSpecialNeeds_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSingle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            cPrice TravelPrice = new cPrice();
            ITax1 AirTax = new ITax1();
            double[] TravelCost = new double[20];
            double[] TaxCost = new double[20];
            double Total;

            if (cmbDestination.Text == "india -5 Days in new Delhi")
            {
                TravelCost[0] = TravelPrice.Ghana + TravelPrice.Airport_Tax + TravelPrice.Air_Miles + TravelPrice.Insurance + TravelPrice.Ext_luggage;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblsubtotal.Text = string.Format("{0:C}", TravelCost[0]);
                lblTax.Text = string.Format("{0:C}", TaxCost[0]);
                lblTotal.Text = string.Format("{0:C}", Total);
            }


            if (cmbDestination.Text == "Italy -5 days in Roma")
            {
                TravelCost[0] = TravelPrice.Italy + TravelPrice.Airport_Tax + TravelPrice.Air_Miles + TravelPrice.Insurance + TravelPrice.Ext_luggage;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]); ;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblsubtotal.Text = string.Format("{0:C}", TravelCost[0]);
                lblTax.Text = string.Format("{0:C}", TaxCost[0]);
                lblTotal.Text = string.Format("{0:C}", Total);
            }

            if (cmbDestination.Text == "Canada -7Days in ToronTo")
            {
                TravelCost[0] = TravelPrice.Canada + TravelPrice.Airport_Tax + TravelPrice.Air_Miles + TravelPrice.Insurance + TravelPrice.Ext_luggage;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]); ;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblsubtotal.Text = string.Format("{0:C}", TravelCost[0]);
                lblTax.Text = string.Format("{0:C}", TaxCost[0]);
                lblTotal.Text = string.Format("{0:C}", Total);
            }

            if (cmbDestination.Text == "Canada -7 Days in Ottawa")
            {
                TravelCost[0] = TravelPrice.Canada_0 + TravelPrice.Airport_Tax + TravelPrice.Air_Miles + TravelPrice.Insurance + TravelPrice.Ext_luggage;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]); ;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblsubtotal.Text = string.Format("{0:C}", TravelCost[0]);
                lblTax.Text = string.Format("{0:C}", TaxCost[0]);
                lblTotal.Text = string.Format("{0:C}", Total);
            }

            if (cmbDestination.Text == "Norway -7 Days in Oslo")
            {
                TravelCost[0] = TravelPrice.Norway + TravelPrice.Airport_Tax + TravelPrice.Air_Miles + TravelPrice.Insurance + TravelPrice.Ext_luggage;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]); ;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblsubtotal.Text = string.Format("{0:C}", TravelCost[0]);
                lblTax.Text = string.Format("{0:C}", TaxCost[0]);
                lblTotal.Text = string.Format("{0:C}", Total);
            }
            if (cmbDestination.Text == "Nigeria -5 Days in Logos Eko Atlantic")
            {
                TravelCost[0] = TravelPrice.nigeria + TravelPrice.Airport_Tax + TravelPrice.Air_Miles + TravelPrice.Insurance + TravelPrice.Ext_luggage;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]); ;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblsubtotal.Text = string.Format("{0:C}", TravelCost[0]);
                lblTax.Text = string.Format("{0:C}", TaxCost[0]);
                lblTotal.Text = string.Format("{0:C}", Total);
            }

            if (cmbDestination.Text == "Somali -10 Days in mogadishu")
            {
                TravelCost[0] = TravelPrice.Mogadisho + TravelPrice.Airport_Tax + TravelPrice.Air_Miles + TravelPrice.Insurance + TravelPrice.Ext_luggage;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]); ;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblsubtotal.Text = string.Format("{0:C}", TravelCost[0]);
                lblTax.Text = string.Format("{0:C}", TaxCost[0]);
                lblTotal.Text = string.Format("{0:C}", Total);
            }

            if (cmbDestination.Text == "saud_Arabia -8 Days in Riyaadh")
            {
                TravelCost[0] = TravelPrice.saud_Arabia + TravelPrice.Airport_Tax + TravelPrice.Air_Miles + TravelPrice.Insurance + TravelPrice.Ext_luggage;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]); ;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblsubtotal.Text = string.Format("{0:C}", TravelCost[0]);
                lblTax.Text = string.Format("{0:C}", TaxCost[0]);
                lblTotal.Text = string.Format("{0:C}", Total);
            }

            if (cmbDestination.Text == "UK -5 Days in London")
            {
                TravelCost[0] = TravelPrice.Uk + TravelPrice.Airport_Tax + TravelPrice.Air_Miles + TravelPrice.Insurance + TravelPrice.Ext_luggage;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]); ;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblsubtotal.Text = string.Format("{0:C}", TravelCost[0]);
                lblTax.Text = string.Format("{0:C}", TaxCost[0]);
                lblTotal.Text = string.Format("{0:C}", Total);
            }

            if (cmbDestination.Text == "France -5 Days in Paris")
            {
                TravelCost[0] = TravelPrice.France + TravelPrice.Airport_Tax + TravelPrice.Air_Miles + TravelPrice.Insurance + TravelPrice.Ext_luggage;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]); ;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblsubtotal.Text = string.Format("{0:C}", TravelCost[0]);
                lblTax.Text = string.Format("{0:C}", TaxCost[0]);
                lblTotal.Text = string.Format("{0:C}", Total);
            }
        }

        private void btnReciept_Click(object sender, EventArgs e)
        {
            int Num1;
            Random rnd = new Random();
            Num1 = rnd.Next(4238, 34238);
            Num1 = 1325 + Num1;
            string refs = Convert.ToString(Num1);
            //-----------------------------------------------------------------------------
            rtReceipt.AppendText("\t Said Travel Agency:\n\n"
            + "Ref:\t\t\t\t" + refs
            + "\n-----------------------------------------------------"
            + "\nName:\t\t\t" + txtFristname.Text
            + "\nSurname:\t\t\t" + txtSurname.Text
            + "\nAddress:\t\t\t" + txtAddres.Text
            + "\nPostCode:\t\t\t" + txtPostCode.Text
            + "\nTelephone:\t\t\t" + txtTalephone.Text
            + "\nDestination:\t\t\t" + cmbDestination.Text
            + "\n-----------------------------------------------------"
            + "\nTax:\t\t\t" + lblTax.Text
            + "\nSubTotal:\t\t\t" + lblsubtotal.Text
            + "\nTotal:\t\t\t" + lblTotal.Text



            + "\n----------------------------------------------------"
            + "\n\n\t Thanks for using Said Travel Agency");

               using (SqlConnection conn = main.connection())
               {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "stprecepreport1";
                cmd.Parameters.AddWithValue("@firstname", txtFristname.Text);
                cmd.Parameters.AddWithValue("@lastname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@addres", txtAddres.Text);
                cmd.Parameters.AddWithValue("@postcode", txtPostCode.Text);
                cmd.Parameters.AddWithValue("@telephone", txtTalephone.Text);
                cmd.Parameters.AddWithValue("@destination", cmbDestination.Text);
                cmd.Parameters.AddWithValue("@tax", lblTax.Text);
                cmd.Parameters.AddWithValue("@subtotal", lblsubtotal.Text);
                cmd.Parameters.AddWithValue("@total", lblTotal.Text);
                cmd.Parameters.AddWithValue("@type", "insert");
                cmd.ExecuteNonQuery();
                MessageBox.Show("SAve", "sa", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime iTime= DateTime.Now;
            lblTime.Text=iTime.ToLongTimeString();
            DateTime iDate= DateTime.Now;
            lblDate.Text=iDate.ToLongDateString();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            REport r = new REport();
            r.Show  ();
        }
    }
}
