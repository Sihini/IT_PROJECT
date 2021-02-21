using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleManagement
{
    public partial class BOOKINGREPORT : Form
    {
        public BOOKINGREPORT()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        Bitmap bmp;

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void BOOKINGREPORT_Load(object sender, EventArgs e)
        {
            using (BOOKINGREPORTEntities db = new BOOKINGREPORTEntities())
            {
                bookingBindingSource.DataSource = db.Bookings.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            booking1 B1 = new booking1();
            B1.Show();
        }
    }
    }

