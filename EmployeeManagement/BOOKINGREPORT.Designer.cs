namespace VehicleManagement
{
    partial class BOOKINGREPORT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BOOKINGREPORT));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.reservationNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationNoDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.driverIDDataGridViewTextBoxColumn,
            this.reservationDateDataGridViewTextBoxColumn,
            this.vehicleNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(178, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(779, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(779, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reservationNoDataGridViewTextBoxColumn
            // 
            this.reservationNoDataGridViewTextBoxColumn.DataPropertyName = "Reservation_No";
            this.reservationNoDataGridViewTextBoxColumn.HeaderText = "Reservation_No";
            this.reservationNoDataGridViewTextBoxColumn.Name = "reservationNoDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_Name";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer_Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // driverIDDataGridViewTextBoxColumn
            // 
            this.driverIDDataGridViewTextBoxColumn.DataPropertyName = "Driver_ID";
            this.driverIDDataGridViewTextBoxColumn.HeaderText = "Driver_ID";
            this.driverIDDataGridViewTextBoxColumn.Name = "driverIDDataGridViewTextBoxColumn";
            // 
            // reservationDateDataGridViewTextBoxColumn
            // 
            this.reservationDateDataGridViewTextBoxColumn.DataPropertyName = "Reservation_Date";
            this.reservationDateDataGridViewTextBoxColumn.HeaderText = "Reservation_Date";
            this.reservationDateDataGridViewTextBoxColumn.Name = "reservationDateDataGridViewTextBoxColumn";
            // 
            // vehicleNumberDataGridViewTextBoxColumn
            // 
            this.vehicleNumberDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Number";
            this.vehicleNumberDataGridViewTextBoxColumn.HeaderText = "Vehicle_Number";
            this.vehicleNumberDataGridViewTextBoxColumn.Name = "vehicleNumberDataGridViewTextBoxColumn";
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataSource = typeof(VehicleManagement.Booking);
            // 
            // BOOKINGREPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 544);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BOOKINGREPORT";
            this.Text = "BOOKINGREPORT";
            this.Load += new System.EventHandler(this.BOOKINGREPORT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}