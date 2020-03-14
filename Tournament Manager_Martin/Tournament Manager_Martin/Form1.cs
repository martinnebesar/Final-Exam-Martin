using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tournament_Manager_Martin
{
    public partial class Form1 : Form
    {
        private string connStr;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbTeamName.Text) ||
                String.IsNullOrWhiteSpace(tbTeamName.Text) ||
                tbTeamName.Text.Length <= 2)
            {
                lblError.Visible = true;
                lblError.Text = "Invalid Team Name";
                tbTeamName.Focus();
            }
            else if (String.IsNullOrEmpty(tbTeamName.Text) ||
                String.IsNullOrWhiteSpace(tbTeamName.Text) ||
                tbCoach.Text.Length < 2)
            {
                lblError.Visible = true;
                lblError.Text = "Invalid Coach";
                tbCoach.Focus();
            }
            else if (String.IsNullOrEmpty(tbTeamID.Text) ||
              String.IsNullOrWhiteSpace(tbTeamID.Text) ||
              tbTeamID.Text.Length <= 2)
            {
                lblError.Visible = true;
                lblError.Text = "Invalid Team ID";
                tbTeamID.Focus();
            }
            else if (String.IsNullOrEmpty(tbAddressLine1.Text) ||
              String.IsNullOrWhiteSpace(tbAddressLine1.Text) ||
              tbAddressLine1.Text.Length <= 2)
            {
                lblError.Visible = true;
                lblError.Text = "Invalid Address 1";
                tbAddressLine1.Focus();
            }
            else if (String.IsNullOrEmpty(tbAddressLine2.Text) ||
              String.IsNullOrWhiteSpace(tbAddressLine2.Text) ||
              tbAddressLine2.Text.Length <= 2)
            {
                lblError.Visible = true;
                lblError.Text = "Invalid Address 2";
                tbAddressLine2.Focus();
            }
            else if (String.IsNullOrEmpty(tbCity.Text) ||
              String.IsNullOrWhiteSpace(tbCity.Text) ||
              tbCity.Text.Length <= 2)
            {
                lblError.Visible = true;
                lblError.Text = "Invalid City";
                tbCity.Focus();
            }
            else if (String.IsNullOrEmpty(tbContactNumber.Text) ||
              String.IsNullOrWhiteSpace(tbContactNumber.Text) ||
              tbContactNumber.Text.Length <= 2)
            {
                lblError.Visible = true;
                lblError.Text = "Invalid Contact Number";
                tbContactNumber.Focus();
            }
            else if (String.IsNullOrEmpty(tbPostalCode.Text) ||
              String.IsNullOrWhiteSpace(tbPostalCode.Text) ||
              tbPostalCode.Text.Length <= 2)
            {
                lblError.Visible = true;
                lblError.Text = "Invalid Postal Code";
                tbPostalCode.Focus();
            }
            else if (String.IsNullOrEmpty(tbEmail.Text) ||
              String.IsNullOrWhiteSpace(tbEmail.Text) ||
              tbEmail.Text.Length <= 2)
            {
                lblError.Visible = true;
                lblError.Text = "Invalid Email";
                tbEmail.Focus();
            }
            else if (String.IsNullOrEmpty(tbDirector.Text) ||
              String.IsNullOrWhiteSpace(tbDirector.Text) ||
              tbDirector.Text.Length <= 2)
            {
                lblError.Visible = true;
                lblError.Text = "Invalid Director";
                tbDirector.Focus();
            }
            else if (String.IsNullOrEmpty(tbCreatedby.Text) ||
              String.IsNullOrWhiteSpace(tbCreatedby.Text) ||
              tbCreatedby.Text.Length <= 2)
            {
                lblError.Visible = true;
                lblError.Text = "Invalid Created by";
                tbCreatedby.Focus();
            }

            else
            {
                lblError.Visible = false;
                AddRecord();
            }
        }

        private void AddRecord()
        {
            throw new NotImplementedException();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            tbTeamName.Clear();
            tbCoach.Clear();
            tbTeamID.Clear();
            tbAddressLine1.Clear();
            tbAddressLine2.Clear();
            tbCity.Clear();
            tbContactNumber.Clear();
            tbPostalCode.Clear();
            tbEmail.Clear();
            tbDirector.Clear();
            tbCreatedby.Clear();
            lblError.Visible = false;
            lblOK.Visible = false;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbTeamName.Text))
            {
                tbTeamName.Text = 0.ToString();
            }
            else if (String.IsNullOrWhiteSpace(tbCoach.Text))
            {
                tbCoach.Text = 0.ToString();
            }
            else if (String.IsNullOrWhiteSpace(tbTeamID2.Text))
            {
                tbTeamID2.Text = 0.ToString();
            }
            else if (String.IsNullOrWhiteSpace(tbAddressLine3.Text))
            {
                tbAddressLine3.Text = 0.ToString();
            }
            else if (String.IsNullOrWhiteSpace(tbAddressLine4.Text))
            {
                tbAddressLine4.Text = 0.ToString();
            }
            else if (String.IsNullOrWhiteSpace(tbCity2.Text))
            {
                tbCity2.Text = 0.ToString();
            }
            else if (String.IsNullOrWhiteSpace(tbContactNumber2.Text))
            {
                tbContactNumber2.Text = 0.ToString();
            }
            else if (String.IsNullOrWhiteSpace(tbPostalCode2.Text))
            {
                tbPostalCode2.Text = 0.ToString();
            }
            else if (String.IsNullOrWhiteSpace(tbEmail2.Text))
            {
                tbEmail2.Text = 0.ToString();
            }
            else if (String.IsNullOrWhiteSpace(tbDirector2.Text))
            {
                tbDirector2.Text = 0.ToString();
            }
            else if (String.IsNullOrWhiteSpace(tbCreatedby2.Text))
            {
                tbCreatedby2.Text = 0.ToString();
            }
            else
            {
                lblErrorSearch.Visible = false;
                SearchRecord();
            }
        }

        private void SearchRecord()
        {
            throw new NotImplementedException();
        }

        private void BtnClear2_Click(object sender, EventArgs e)
        {
            tbTeamName.Clear();
            tbCoach.Clear();
            tbTeamID2.Clear();
            tbAddressLine3.Clear();
            tbAddressLine4.Clear();
            tbCity2.Clear();
            tbContactNumber2.Clear();
            tbPostalCode2.Clear();
            tbEmail2.Clear();
            tbDirector2.Clear();
            tbCreatedby2.Clear();
            lblError.Visible = false;
            lblOK.Visible = false;
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string testConn = "SELECT * FROM Teams";
                SqlCommand cmd = new SqlCommand(testConn, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int total = 0;

                while (reader.Read())
                {
                    string fullName = reader["Team Name"] + " " + reader["Coach"] + " " + reader["Team ID"] + " " + reader["Address 1"] + " " + reader["Address 2"] + " " + reader["City"] + " " + reader["Contact Number"] + " " + reader["Postal Code"] + " " + reader["Email"] + " " + reader["Director"] + " " + reader["Created by"] + " ";
                    lbTeamsExport.Items.Add(fullName);
                    total++;
                }                
            }
            btnExport.Enabled = true;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\teamlist.txt"))
            {
                foreach (String itemRow in lbTeamsExport.Items)
                {
                    sw.WriteLine(itemRow.ToString());
                }
            }
            lblExport.Visible = true;
            lblExport.Text = "Successful!";
        }
    }
}
