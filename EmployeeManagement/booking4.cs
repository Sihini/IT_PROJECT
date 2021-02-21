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

namespace VehicleManagement
{
    public partial class booking4 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K3UHSN9;Initial Catalog=BOOKING;Integrated Security=True");
        SqlDataReader sdr;
        String auno;
        String sql;
        SqlDataReader dr;
        SqlCommand cmd;
        bool Mode = true;

        public booking4()
        {
            InitializeComponent();

            booking7 b7 = new booking7();
        }

        private void booking4_Load(object sender, EventArgs e)
        {
            getbookingdeials();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            booking1 b1 = new booking1();
            b1.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }

        public void getbookingdeials()
        {
            con.Open();
            this.ResNo.Text = booking7.bookingid;

            string sqlselectquery = "select * from Booking where [Reservation No] = " + booking7.bookingid;

            cmd = new SqlCommand(sqlselectquery, con);
            cmd.CommandType = CommandType.Text;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CName.Text = dr.GetValue(1).ToString();
                Did.Text = dr.GetValue(2).ToString();
                Rdate.Text = dr.GetValue(3).ToString();
                VNumber.Text = dr.GetValue(4).ToString();

            }
            con.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            con.Open();
            string update = "UPDATE Booking set [Reservation No] = '" + this.ResNo.Text.ToString() + "' , [Customer Name] = '" + this.CName.Text.ToString() + "', [Driver ID] = '" + this.Did.Text.ToString() + "' , [Reservation Date] = '" + this.Rdate.Text.ToString() + "', [Vehicle Number] = '" + this.VNumber.Text.ToString() + "'where [Reservation No] = '" + this.ResNo.Text+"'";
            cmd = new SqlCommand(update, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated The Details");

            con.Close();
        }
    }
}
