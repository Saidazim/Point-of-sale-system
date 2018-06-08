using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SAD_CW2_2017_2018_00004628
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "manager" && tbxPassword.Text == "1")
            {
                this.Hide();
                ManagerForm mf = new ManagerForm();
                mf.Show();
                lblError.Text = "";
            }
            else if (tbxUsername.Text == "salesperson" && tbxPassword.Text == "1")
            {
                this.Hide();
                Till till = new Till();
                till.Show();
                lblError.Text = "";
            }

            else if (tbxUsername.Text == "" || tbxPassword.Text == "")
            {
                lblError.Text = "Fields should not be blank";
            }
            else
            {
                lblError.Text = "Incorrect Username or Password";
            }
        }
    }
}
