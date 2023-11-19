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

namespace CS488LocalDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Env ConnString = new Env();
            string ServerConn = ConnString.SrvConn;
            SqlConnection conn = new SqlConnection(connectionString: ServerConn);

            try
            {
                SqlCommand get_menu = new SqlCommand("Select * from menu_items", conn);
                conn.Open();
                SqlDataReader menu = get_menu.ExecuteReader();

                while (menu.Read())
                {
                    if (!(menu.Equals(null)))
                    {
                        for (int i = 0; i < menu.FieldCount; i++)
                        {
                            string myString = menu.GetValue(i).ToString();
                            Console.WriteLine(myString);
                        }
                    }
                }
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
