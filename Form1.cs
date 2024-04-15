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

namespace DatabaseManagementDemo
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           loadDBS();
           editPanel.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loadDBS()
        {
            conn = new SqlConnection("Data Source=(localdb)\\Projects;Initial Catalog=Vehicles;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            conn.Open();
            cmd = new SqlCommand("SELECT plate_no as [Plate No.], vehicle_type as [Vehicle Type], vehicle_brand as [Vehicle Brand], parkin_datetime as [Park-in Date/Time] FROM vehiclesDBS");
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Vehicles");
            vehiclesDB.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string plateNo = plateNoBox.Text;
            string vehicleType = vehicleTypeBox.Text;
            string vehicleBrand = vehicleBrandBox.Text;
            string datetime = "04/01/24 11:59PM";
            conn = new SqlConnection("Data Source=(localdb)\\Projects;Initial Catalog=Vehicles;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            conn.Open();
            cmd = new SqlCommand("INSERT INTO vehiclesDBS " + 
            "VALUES('" + plateNo + "', '"+ vehicleType + "', '" + vehicleBrand +"', '" + datetime + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            loadDBS();
        }

        private void vehiclesDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Edit Data?", "ParkWise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes) {
                editPanel.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=(localdb)\\Projects;Initial Catalog=Vehicles;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            conn.Open();
            cmd = new SqlCommand("SELECT plate_no as [Plate No.], vehicle_type as [Vehicle Type], vehicle_brand as [Vehicle Brand], parkin_datetime as [Park-in Date/Time] FROM vehiclesDBS WHERE plate_no like '" + textBox1.Text + "%'", conn);
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Vehicles");
            vehiclesDB.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=(localdb)\\Projects;Initial Catalog=Vehicles;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            conn.Open();
            cmd = new SqlCommand("SELECT plate_no as [Plate No.], vehicle_type as [Vehicle Type], vehicle_brand as [Vehicle Brand], parkin_datetime as [Park-in Date/Time] FROM vehiclesDBS");
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Vehicles");
            vehiclesDB.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            string newPN = editPN.Text;
            string newVT = editVT.Text;
            string newVB = editVB.Text;
           // string oldPN =  vehiclesDB.CurrentRow.Cells[0].Value.ToString() ;
            conn = new SqlConnection("Data Source=(localdb)\\Projects;Initial Catalog=Vehicles;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            conn.Open();
            cmd = new SqlCommand("UPDATE vehiclesDBS SET plate_no = @newPN, vehicle_type = @newVT , vehicle_brand = @newVB WHERE plate_no = @oldPN", conn);
            cmd.Parameters.AddWithValue("@newPN", newPN);
            cmd.Parameters.AddWithValue("@newVT", newVT);
            cmd.Parameters.AddWithValue("@newVB", newVB);
            cmd.Parameters.AddWithValue("@oldPN", vehiclesDB.CurrentRow.Cells[0].Value.ToString());
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data edited successfully!", "Parkwise", MessageBoxButtons.OK, MessageBoxIcon.Information);
            editPanel.Hide();
            loadDBS();
        }
    }
       
 
}
