using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harman_Video_Rental_Store
{
    public partial class Form1 : Form
    {
        Query dataQuery = null;
        public Form1()
        {
            InitializeComponent();
        }
        public int EmptyCheckCustomer() {
            if (txtName.Text.ToString().Equals("") || txtAddress.Text.ToString().Equals("") || txtContact.Text.ToString().Equals("")) {
                return 1;
            }
            else {
                return 0;
            }
        }
        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            if (EmptyCheckCustomer() == 0)
            {
                //add record 
                /// INsert the record of the customer we can only INsert the customer after selecting the details of the customer 
                dataQuery = new Query();
                dataQuery.Insert("insert into Register (CustomerName,CustomerAddress,CustomerContact) values('"+txtName.Text.ToString()+"','"+txtAddress.Text.ToString()+"','"+txtContact.Text.ToString()+"')");
                MessageBox.Show("Customer is Register in the Portal ");
                txtName.Text = "";
                txtAddress.Text = "";
                txtContact.Text = "";
                lblCustomerID.Text = "";
            }
            else {
                MessageBox.Show("Check the details of the Customer before saving ");
            }
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            if (lblCustomerID.Text.ToString().Equals(""))
            {
                MessageBox.Show("Select Customer first to delete him ");
            }
            else {

                ///deelte the record of the customer we can only delete the customer after selecting the details of the customer 
                dataQuery = new Query();

                if (dataQuery.Count("Select * from Rent where CustomerID=" + Convert.ToInt32(lblCustomerID.Text.ToString()) + " and VideoReturn='issue'") == 0)
                {



                    dataQuery.Delete("Delete from Register where ID=" + Convert.ToInt32(lblCustomerID.Text.ToString()) + "");
                    MessageBox.Show("Register Customer is Deleted ");
                }
                else {
                    MessageBox.Show("Customer Has  a video on rent ");
                }
                txtName.Text = "";
                txtAddress.Text = "";
                txtContact.Text = "";
                lblCustomerID.Text = "";
            }
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            if (EmptyCheckCustomer() == 1 || lblCustomerID.Text.ToString().Equals(""))
            {
                MessageBox.Show("Select and fill all the details to update ");
            }
            else {
                ///Update the record of the customer we can only Update the customer after selecting the details of the customer 
                dataQuery = new Query();
                dataQuery.Update("update Register set CustomerName='"+txtName.Text+"',CustomerAddress='"+txtAddress.Text+"',CustomerContact='"+txtContact.Text+"' where ID="+Convert.ToInt32(lblCustomerID.Text.ToString())+"");
                MessageBox.Show("Record is Updated of the Customer ");
                txtName.Text = "";
                txtAddress.Text = "";
                txtContact.Text = "";
                lblCustomerID.Text = "";
            }
        }

        public int EmptyCheckVideo() {
            if (txtTitle.Text.ToString().Equals("") || txtRatting.Text.ToString().Equals("") || txtCost.Text.ToString().Equals("") || txtCopies.Text.ToString().Equals("") || txtGenre.Text.ToString().Equals("")) {
                return 1;
            }
            else{
                return 0;

            }
        }
        private void btnVideoADd_Click(object sender, EventArgs e)
        {
            //database query to  add the movie which is by add in the database 
            if (EmptyCheckVideo() == 1)
            {
                MessageBox.Show("Record must be filled first ");
            }
            else {
                dataQuery = new Query();
                dataQuery.Insert("insert into Video (VideoTitle,VideoRatting,VideoYear,VideoCost,VideoCopies,VideoGenre) values('"+txtTitle.Text+"','"+txtRatting.Text+"',"+Convert.ToInt32(txtYear.Text.ToString())+","+Convert.ToInt32(txtCost.Text.ToString())+","+Convert.ToInt32(txtCopies.Text.ToString())+",'"+txtGenre.Text.ToString()+"')");
                MessageBox.Show("Video Details are added in the Store ");
                txtTitle.Text = "";
                txtRatting.Text = "";
                txtCopies.Text = "";
                txtCost.Text = "";
                txtYear.Text = "";
                txtGenre.Text = "";
                lblVideoID.Text = "";

            }
        }

        private void btnVideoDelete_Click(object sender, EventArgs e)
        {
            //database query to  delete the movie  which is by mistake add in the database 
            if (lblVideoID.Text.ToString().Equals(""))
            {
                MessageBox.Show("Select  the Video First to delete");

            }
            else {
                dataQuery = new Query();
                if (dataQuery.Count("select * from Rent where VideoID=" + Convert.ToInt32(lblVideoID.Text.ToString()) + " and VideoReturn='issue'") == 0)
                {


                    dataQuery.Delete("Delete from Video where ID=" + Convert.ToInt32(lblVideoID.Text.ToString()) + "");
                    MessageBox.Show("Video is deleted from the record permmanently ");
                }
                else {
                    MessageBox.Show("this video is booked ");
                }
                txtTitle.Text = "";
                txtRatting.Text = "";
                txtCopies.Text = "";
                txtCost.Text = "";
                txtYear.Text = "";
                txtGenre.Text = "";
                lblVideoID.Text = "";

            }

        }

        private void btnVideoUpdate_Click(object sender, EventArgs e)
        {
            //database query to  Update the movie on rent which is by mistake add in the database 
            if (EmptyCheckVideo() == 1 || lblVideoID.Text.ToString().Equals(""))
            {
                MessageBox.Show("Select the Video First to Update ");
            }
            else {
                dataQuery = new Query();
                dataQuery.Update("Update Video set VideoTitle='"+txtTitle.Text.ToString()+"',VideoRatting='"+txtRatting.Text.ToString()+"',VideoYear="+Convert.ToInt32(txtYear.Text.ToString())+",VideoCost="+Convert.ToInt32(txtCost.Text.ToString())+",VideoCopies="+Convert.ToInt32(txtCopies.Text.ToString())+",VideoGenre='"+txtGenre.Text.ToString()+"' where ID="+Convert.ToInt32(lblVideoID.Text.ToString())+"");
                MessageBox.Show("Video Details are updated ");
                txtTitle.Text = "";
                txtRatting.Text = "";
                txtCopies.Text = "";
                txtCost.Text = "";
                txtYear.Text = "";
                txtGenre.Text = "";
                lblVideoID.Text = "";

            }
        }

        private void btnVideoIssue_Click(object sender, EventArgs e)
        {
            //database query to issue the movie on rent 
            if (lblCustomerID.Text.ToString().Equals("") || lblVideoID.Text.ToString().Equals(""))
            {
                MessageBox.Show("Select Video and Customer to issue ");
            }
            else {
                dataQuery = new Query();
                if (dataQuery.Count("Select * from Rent where CustomerID=" + Convert.ToInt32(lblCustomerID.Text.ToString()) + " and VideoReturn='issue'") < 2)
                {
                    if (dataQuery.Count("Select * from Rent Where VideoID=" + Convert.ToInt32(lblVideoID.Text.ToString()) + " and VideoReturn='issue'") < Convert.ToInt32(txtCopies.Text))
                    {





                        dataQuery.Insert("Insert into Rent (VideoID,CustomerID,Issue,VideoReturn) values(" + Convert.ToInt32(lblVideoID.Text.ToString()) + "," + Convert.ToInt32(lblCustomerID.Text.ToString()) + ",'" + BookingDate.Text.ToString() + "','issue')");
                        MessageBox.Show("Movie is Issued on Rent On " + txtCost.Text + " Dollar per Day Rent ");
                    }
                    else {
                        MessageBox.Show("All Video are booked ");
                    }
                }
                else {
                    MessageBox.Show("You already have 2 Video on Rent ");
                }
                lblCustomerID.Text = "";
                lblVideoID.Text = "";
                txtName.Text = "";
                txtAddress.Text = "";
                txtContact.Text = "";
                lblCustomerID.Text = "";
                txtTitle.Text = "";
                txtRatting.Text = "";
                txtCopies.Text = "";
                txtCost.Text = "";
                txtYear.Text = "";
                txtGenre.Text = "";
                lblVideoID.Text = "";
            }
        }

        private void btnVideoDel_Click(object sender, EventArgs e)
        {
            //database query to  delete the movie on rent which is by mistake add in the database 
            if (lblRentalID.Text.ToString().Equals("")) {
                MessageBox.Show("Select the Rental Video to Delete ");
            }
            else {
                dataQuery = new Query();
                dataQuery.Delete("Delete from Rent where ID=" + Convert.ToInt32(lblRentalID.Text.ToString()) + "");
                MessageBox.Show("Record is deleted that is bymistake store in the database ");
                lblRentalID.Text = "";
                lblVideoID.Text = "";
                lblCustomerID.Text = "";

                lblCustomerID.Text = "";
                lblVideoID.Text = "";
                txtName.Text = "";
                txtAddress.Text = "";
                txtContact.Text = "";
                lblCustomerID.Text = "";
                txtTitle.Text = "";
                txtRatting.Text = "";
                txtCopies.Text = "";
                txtCost.Text = "";
                txtYear.Text = "";
                txtGenre.Text = "";
                lblVideoID.Text = "";
            }
        }

        private void txtCopies_TextChanged(object sender, EventArgs e)
        {
            int Crntyear = DateTime.Now.Year;

            int Year = Crntyear - Convert.ToInt32(txtYear.Text.ToString());
            // MessageBox.Show(diff.ToString());
            if (Year >= 5)
            {
                txtCost.Text = "2";
            }
            else if (Year >= 0 && Year < 5)
            {
                txtCost.Text = "5";
            }
        }

        private void btnCustomerPanel_Click(object sender, EventArgs e)
        {
            //fetch the details from the database server
            dataQuery = new Query();
            DataTable tbl=dataQuery.Search("select * from Register");
            Database.DataSource = tbl;
            rbCustomer.Checked = true;
            rbVideo.Checked = false;
            rbRent.Checked = false;

            
        }

        private void btnVideoPanel_Click(object sender, EventArgs e)
        {
            //fetch the details from the database server
            dataQuery = new Query();
            DataTable tbl = dataQuery.Search("select * from Video");
            Database.DataSource = tbl;
            rbCustomer.Checked =false;
            rbVideo.Checked =true;
            rbRent.Checked = false;


        }

        private void btnRentalPanel_Click(object sender, EventArgs e)
        {
            //fetch the details from the database server
            dataQuery = new Query();
            DataTable tbl = dataQuery.Search("select * from Rent");
            Database.DataSource = tbl;
            rbCustomer.Checked = false;
            rbVideo.Checked = false;
            rbRent.Checked =true;


        }

        private void Database_DoubleClick(object sender, EventArgs e)
        {
            if (rbCustomer.Checked==true) {
                lblCustomerID.Text = Database.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = Database.CurrentRow.Cells[1].Value.ToString();
                txtAddress.Text = Database.CurrentRow.Cells[2].Value.ToString();
                txtContact.Text = Database.CurrentRow.Cells[3].Value.ToString();
                rbCustomer.Checked = false;
            }

            if (rbVideo.Checked==true) {
                lblVideoID.Text = Database.CurrentRow.Cells[0].Value.ToString();
                txtTitle.Text = Database.CurrentRow.Cells[1].Value.ToString();
                txtRatting.Text = Database.CurrentRow.Cells[2].Value.ToString();
                txtYear.Text = Database.CurrentRow.Cells[3].Value.ToString();
                txtCost.Text = Database.CurrentRow.Cells[4].Value.ToString();
                txtCopies.Text = Database.CurrentRow.Cells[5].Value.ToString();
                txtGenre.Text = Database.CurrentRow.Cells[6].Value.ToString();
                rbVideo.Checked = false;
            }
            if (rbRent.Checked==true) {
                lblRentalID.Text = Database.CurrentRow.Cells[0].Value.ToString();
                lblVideoID.Text = Database.CurrentRow.Cells[1].Value.ToString();
                lblCustomerID.Text = Database.CurrentRow.Cells[2].Value.ToString();
                BookingDate.Text = Database.CurrentRow.Cells[3].Value.ToString();
                rbRent.Checked = false;
            }



        }

        public int charges() {
            dataQuery = new Query();
            DataTable tbl=dataQuery.Search("Select * from Video where ID=" + Convert.ToInt32(lblVideoID.Text.ToString()) + "");
            int charg = Convert.ToInt32(tbl.Rows[tbl.Rows.Count - 1]["VideoCost"].ToString());
            DateTime current_date = DateTime.Now;

            //convert the old date from string to Date fromat
            DateTime old_date = Convert.ToDateTime(BookingDate.Text.ToString());


            //get the difference in the days fromat
            String Daysdiff = (current_date - old_date).TotalDays.ToString();


            // calculate the round off value 
            Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));



            int totalCharges = Convert.ToInt32(DaysInterval) * charg;

            return totalCharges;
        }
        private void btnVideoReturn_Click(object sender, EventArgs e)
        {
            if (lblRentalID.Text.ToString().Equals(""))
            {
                MessageBox.Show("Select the rental video to return ");
            }
            else {
                dataQuery = new Query();
                dataQuery.Update("update Rent set VideoID="+Convert.ToInt32(lblVideoID.Text.ToString())+",CustomerID="+Convert.ToInt32(lblCustomerID.Text.ToString())+",Issue='"+BookingDate.Text.ToString()+"',VideoReturn='"+ReturnDate.Text.ToString()+"' where ID="+Convert.ToInt32(lblRentalID.Text.ToString())+"");
                MessageBox.Show("Charges is ==$" + charges());
                lblRentalID.Text = "";
                lblVideoID.Text = "";
                lblCustomerID.Text = "";

                lblCustomerID.Text = "";
                lblVideoID.Text = "";
                txtName.Text = "";
                txtAddress.Text = "";
                txtContact.Text = "";
                lblCustomerID.Text = "";
                txtTitle.Text = "";
                txtRatting.Text = "";
                txtCopies.Text = "";
                txtCost.Text = "";
                txtYear.Text = "";
                txtGenre.Text = "";
                lblVideoID.Text = "";


            }

        }

        private void btnBestVideo_Click(object sender, EventArgs e)
        {
            
            dataQuery = new Query();

            DataTable tbl=dataQuery.Search("select * from Video");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tbl.Rows.Count; x++)
            {
                
                DataTable tblnew =dataQuery.Search("select * from Rent where VideoID=" + Convert.ToInt32(tbl.Rows[x]["ID"].ToString()) + "");

                if (tblnew.Rows.Count > cunt)
                {
                    Title = tbl.Rows[x]["VideoTitle"].ToString();
                    cunt = tblnew.Rows.Count;
                }


            }
            
            //print the Name of the Best Video of the Software1
            
            
            DataTable table = new DataTable();
            table.Columns.Add("Video Title", typeof(String));
            table.Rows.Add(Title);
            Database.DataSource = table;
            
        }

        private void btnBestCustomer_Click(object sender, EventArgs e)
        {
            dataQuery = new Query();

            DataTable tbl = dataQuery.Search("select * from Register ");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tbl.Rows.Count; x++)
            {

                DataTable tblnew = dataQuery.Search("select * from Rent where CustomerID=" + Convert.ToInt32(tbl.Rows[x]["ID"].ToString()) + "");

                if (tblnew.Rows.Count > cunt)
                {
                    Title = tbl.Rows[x]["CustomerName"].ToString();
                    cunt = tblnew.Rows.Count;
                }

            }
            //print the Name of the Best Customer 
            DataTable table = new DataTable();
            table.Columns.Add("Customer Name ", typeof(String));
            table.Rows.Add(Title);
            Database.DataSource = table;
        }
    }
}
