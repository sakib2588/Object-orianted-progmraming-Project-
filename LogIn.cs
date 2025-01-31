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

namespace WindowsFormsApp1
{
    public partial class LogIn : Form
    {
        

        private DatabaseAccess dba { get; set; }
        public LogIn()
        {
            InitializeComponent();
            this.dba = new DatabaseAccess();
           

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string id = User.Text;
            string pass = Pass.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter both UserID and Password.");
                return;
            }

            try
            {
                string sql = "SELECT * FROM User_Info WHERE UserID = @UserID";
                using (SqlCommand cmd = new SqlCommand(sql, dba.Sqlcon))
                {
                    cmd.Parameters.AddWithValue("@UserID", id);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    if (dataSet.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Account not found.");
                        return;
                    }

                    string storedPassword = dataSet.Tables[0].Rows[0]["Password"].ToString();
                    string status = dataSet.Tables[0].Rows[0]["Status"].ToString();
                    string role = dataSet.Tables[0].Rows[0]["Role"].ToString();

                    if (pass == storedPassword) // Hash comparison recommended
                    {
                        if (status == "Active")
                        {
                            if (role == "Admin")
                            {
                                AdminDashboard1 ad = new AdminDashboard1();
                                ad.Show();
                                AdminDashboard1.ID = id;
                                this.Hide();
                            }
                            else if (role == "Staff")
                            {
                                this.Hide();
                                StaffDashboard staff = new StaffDashboard();
                                StaffDashboard.UserID = User.Text;
                                StaffSellProduct.UserID = User.Text;
                                ViewCart.UserID = User.Text;
                                staff.Show();
                            }
                            else
                            {
                                MessageBox.Show("Error: Invalid Role.");
                            }
                        }
                        else if (status == "Inactive")
                        {
                            MessageBox.Show("Your account is inactive. Please contact support.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.User.Text = "";
            this.Pass.Text = "";

        }

        private void metroCheckBox1_CheckedChanged(object sender)
        {
            if (metroCheckBox1.Checked) Pass.PasswordChar = '\0';
            else Pass.PasswordChar = '*';

        }
    }
}
