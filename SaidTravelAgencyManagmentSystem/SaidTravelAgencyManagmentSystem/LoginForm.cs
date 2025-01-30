using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaidTravelAgencyManagmentSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "Abdiwali" && txtPassword.Text == "isak")
            {
                Form1 frMain = new Form1();
                frMain.Show();
                frMain.IsMdiContainer = true;
            }
            else
                MessageBox.Show("Invalid value");
        }
    }
    }

