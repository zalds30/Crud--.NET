using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Crud
{
    internal class db
    {
        public static MySqlCommand cm;
        public static MySqlConnection con;
        public static string strnames;

        public db()
        {
            //Connection to Database
            string cons = "server = 'localhost'; userid = 'root'; password = ''; database = 'dbcrud'; ";
            con = new MySqlConnection(cons);
        }

        //INSERT METHOD
        public static void Insert()
        {
            con.Open();
            cm = new MySqlCommand("INSERT INTO TBLINFORMATION (NAMES) VALUES (@NAMES)", con);
            cm.Parameters.AddWithValue("@NAMES", strnames);
            cm.ExecuteNonQuery();
            MessageBox.Show("Record Save!");
            con.Close();
        }


    }
}
