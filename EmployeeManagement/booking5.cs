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
    public partial class booking5 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K3UHSN9;Initial Catalog=BOOKING;Integrated Security=True");
        SqlDataReader sdr;
        String auno;
        String sql;
        SqlDataReader dr;
        SqlCommand cmd;
        bool Mode = true;

        public booking5()
        {
            InitializeComponent();
            booking8 b8 = new booking8();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            booking1 b1 = new booking1();
            b1.Show();
        }

        public void getbookingdeials()
        {
            con.Open();
            this.ResNo.Text = booking8.bookingid;

            string sqlselectquery = "select * from Booking where [Reservation No] = " + booking8.bookingid;

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



        private void booking5_Load(object sender, EventArgs e)
        {
            getbookingdeials();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            con.Open();
            string delete = "DELETE Booking where [Reservation No] = '" + this.ResNo.Text + "'";
            cmd = new SqlCommand(delete, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted The Details");
        }
    }
}
