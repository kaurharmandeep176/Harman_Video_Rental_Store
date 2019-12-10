using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Harman_Video_Rental_Store
{
   public class Query
    {

        //global declaration of the classes that is used for database connectivity 
        public SqlConnection link;
        public String linkString = "Data Source=DESKTOP-17CKR5L;Initial Catalog=HarmanStore;Integrated Security=True";
        public SqlCommand command;
        public SqlDataReader DtReader;

        // insert command to perform the insert DML Operation 
        public int Insert(String Ins) {
            link = new SqlConnection(linkString);
            link.Open();
            command = new SqlCommand(Ins, link);
            command.ExecuteNonQuery();
            link.Close();
            return 1;
        }

        // Delete command to perform the Delete DML Operation 
        public void Delete(String Ins)
        {
            link = new SqlConnection(linkString);
            link.Open();
            command = new SqlCommand(Ins, link);
            command.ExecuteNonQuery();
            link.Close();
        }

        // Update command to perform the Update DML Operation 
        public void Update(String Ins)
        {
            link = new SqlConnection(linkString);
            link.Open();
            command = new SqlCommand(Ins, link);
            command.ExecuteNonQuery();
            link.Close();
        }

        // Search command to perform the Search DML Operation 
        public DataTable Search(String Ins)
        {
            DataTable tbl = new DataTable();

            link = new SqlConnection(linkString);
            link.Open();
            command = new SqlCommand(Ins, link);
            DtReader =command.ExecuteReader();

            tbl.Load(DtReader);

            link.Close();
            return tbl;
        }

        // Search command to perform the Search DML Operation 
        public int Count(String Ins)
        {
            DataTable tbl = new DataTable();

            link = new SqlConnection(linkString);
            link.Open();
            command = new SqlCommand(Ins, link);
            DtReader = command.ExecuteReader();

            tbl.Load(DtReader);

            link.Close();
            return tbl.Rows.Count;
        }



    }
}
