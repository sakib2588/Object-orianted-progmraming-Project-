using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ManageStaff : Form
    {
        private DatabaseAccess Da { get; set; }
        public ManageStaff()
        {
            InitializeComponent();
            this.Da = new DatabaseAccess();
            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = @"
        SELECT 
            u.UserID AS UserID,
           
            u.PhoneNumber AS PhoneNumber,
            u.Name AS Name,
            u.Password AS Password,
            u.Email AS Email,
            u.Role AS Role,
            u.Status AS Status,
            s.BloodType AS BloodType,
            s.Age AS Age,
            s.Gender AS Gender
        FROM 
            User_Info u
        JOIN 
            Staff s 
        ON 
            u.UserID = s.UserID
        WHERE 
            u.Role = 'Staff';
        ")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.StaffTable.AutoGenerateColumns = true; // Ensure columns are generated automatically
            this.StaffTable.DataSource = ds.Tables[0];
        }
        bool sidebarExpand = true;
        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                Sidebar.Width -= 5;
                if (Sidebar.Width <= 75)
                {
                    sidebarExpand = false;
                    SidebarTransition.Stop();
                    PnDashboard.Width = Sidebar.Width;
                    PnLogOut.Width = Sidebar.Width;
                    panel4.Width = Sidebar.Width;
                    PnStaff.Width = Sidebar.Width;
                    panel2.Width = Sidebar.Width;
                }
            }
            else
            {
                Sidebar.Width += 5;
                if (Sidebar.Width >= 180)
                {
                    sidebarExpand = true;
                    SidebarTransition.Stop();
                    PnDashboard.Width = Sidebar.Width;
                    PnLogOut.Width = Sidebar.Width;
                    panel2.Width = Sidebar.Width;
                    PnStaff.Width = Sidebar.Width;
                    panel4.Width = Sidebar.Width;
                }
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            AdminDashboard1 admin = new AdminDashboard1();
            admin.Show();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ProductInventory product = new ProductInventory();
            product.Show();
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Close();
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ManageStaff staff = new ManageStaff();
            staff.Show();
            this.Close();
        }
        private void ManageStaff_Load(object sender, EventArgs e)
        {
            this.AutoIdGenerate();
            this.StaffTable.ClearSelection();
           
        }
        private void btnStaffShow_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.comBlood.Text = "";  
            this.comGender.Text = "";
            this.comStatus.Text = "";
            this.PopulateGridView();
        }
        private void ClearAll()
        {
            this.txtboxStaffName.Text = "";
            this.txtBoxPhone.Text = "";
            this.txtBoxEmail.Text = "";
            this.txtBoxAge.Text = "";
            this.comBlood.Text = "";
            this.comGender.Text = "";
            this.comStatus.Text = "";
            this.txtBoxPassword.Text = "";
            this.StaffTable.ClearSelection();
            this.AutoIdGenerate();
        }
        private void btnStaffAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValideToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }
                var query = "select * from User_Info where UserID= '" + this.txtBoxStaffID.Text + "'";
                DataTable dt = this.Da.ExecuteQueryTable(query);
                if (dt.Rows.Count == 1)
                {
                    //update
                    var sql = @"update User_Info set Name='" + this.txtboxStaffName.Text + "', PhoneNumber='" + this.txtBoxPhone.Text + "', Email='" + this.txtBoxEmail.Text + "', Password='" + this.txtBoxPassword.Text + "', Role='Staff', Status='" + this.comStatus.Text + "' where UserID='" + this.txtBoxStaffID.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Data Updated");
                    }
                    else
                    {
                        MessageBox.Show("Data Update Failed");
                    }
                }
                else
                {
                    //insert
                    var sql = @"insert into User_Info (UserID, Name, PhoneNumber, Email, Password, Role, Status) values('" + this.txtBoxStaffID.Text + "','" + this.txtboxStaffName.Text + "','" + this.txtBoxPhone.Text + "','" + this.txtBoxEmail.Text + "','" + this.txtBoxPassword.Text + "','Staff','" + this.comStatus.Text + "');";
                    int count = this.Da.ExecuteDMLQuery(sql);
                    if (count == 1)
                    {
                        var sql2 = @"insert into Staff (UserID, BloodType, Age, Gender, Email) values('" + this.txtBoxStaffID.Text + "','" + this.comBlood.Text + "','" + this.txtBoxAge.Text + "','" + this.comGender.Text + "','" + this.txtBoxEmail.Text + "');";
                        int count2 = this.Da.ExecuteDMLQuery(sql2);
                        if (count2 == 1)
                        {
                            MessageBox.Show("Data Inserted");
                        }
                        else
                        {
                            MessageBox.Show("Data Insertion Failed");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data Insertion Failed");
                    }
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private bool IsValideToSave()
        {
            if (string.IsNullOrEmpty(this.txtboxStaffName.Text) || string.IsNullOrEmpty(this.txtBoxPhone.Text) || string.IsNullOrEmpty(this.txtBoxEmail.Text) || string.IsNullOrEmpty(this.txtBoxPassword.Text) || string.IsNullOrEmpty(this.txtBoxAge.Text) || string.IsNullOrEmpty(this.comBlood.Text) || string.IsNullOrEmpty(this.comGender.Text) || string.IsNullOrEmpty(this.comStatus.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void StaffTable_DoubleClick(object sender, EventArgs e)
        {
            this.txtboxStaffName.Text = this.StaffTable.CurrentRow.Cells["Name"].Value.ToString();
            this.txtBoxPhone.Text = this.StaffTable.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            this.txtBoxEmail.Text = this.StaffTable.CurrentRow.Cells["Email"].Value.ToString();
            this.txtBoxPassword.Text = this.StaffTable.CurrentRow.Cells["Password"].Value.ToString();
            this.txtBoxAge.Text = this.StaffTable.CurrentRow.Cells["Age"].Value.ToString();
            this.comBlood.Text = this.StaffTable.CurrentRow.Cells["BloodType"].Value.ToString();
            this.comGender.Text = this.StaffTable.CurrentRow.Cells["Gender"].Value.ToString();
            this.comStatus.Text = this.StaffTable.CurrentRow.Cells["Status"].Value.ToString();
            this.txtBoxStaffID.Text = this.StaffTable.CurrentRow.Cells["UserID"].Value.ToString();
        }
        private void AutoIdGenerate()
        {
            var sql = "SELECT * FROM User_Info;";
            var ds = this.Da.ExecuteQuery(sql);
            var dt = ds.Tables[0];
            int rowCount = dt.Rows.Count;
            if (rowCount > 0)
            {
                string id = dt.Rows[rowCount - 1]["UserID"].ToString();
                string[] str = id.Split('-');
                int num = Convert.ToInt32(str[1]);
                string newId = "Staff-" + (++num).ToString("d3");
                this.txtBoxStaffID.Text = newId;
            }
            else
            {
                this.txtBoxStaffID.Text = "Staff-001";
            }
        }

        private void btnStaffRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.StaffTable.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var id = this.StaffTable.CurrentRow.Cells["UserID"].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + id + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
                var sql = "delete from Staff where UserID = '" + id + "'; delete from User_Info where UserID = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);
                if (count > 0)
                {
                    MessageBox.Show(id.ToUpper() + " has been removed from the list.");
                }
                else
                {
                    MessageBox.Show("Data Deletion Failed");
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}

