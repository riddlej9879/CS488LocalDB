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
            List<MenuItem> FullMenu = new List<MenuItem>();

            Env ConnString = new Env();
            string ServerConn = ConnString.SrvConn;
            SqlConnection conn = new SqlConnection(connectionString: ServerConn);

            try
            {
                SqlCommand get_menu = new SqlCommand("select MENU_ITEM_ID, MENU_ITEMS.PRODUCT_SUB_ID, PRODUCT_CAT.CATEGORY_ID, PRODUCT_CAT.DESCRIPTION, PRODUCT_SUB.DESCRIPTION, ITEM_PRICE from menu_items inner join PRODUCT_SUB on menu_items.PRODUCT_SUB_ID = PRODUCT_SUB.PRODUCT_SUB_ID inner join PRODUCT_CAT on PRODUCT_SUB.CATEGORY_ID = PRODUCT_CAT.CATEGORY_ID", conn);
                conn.Open();
                SqlDataReader menu = get_menu.ExecuteReader();

                while (menu.Read())
                {
                    if (!(menu.Equals(null)))
                    {
                        MenuItem meal = new MenuItem(
                            menu.GetInt32(0), menu.GetInt32(1),
                            menu.GetInt32(2), menu.GetValue(3).ToString(),
                            menu.GetValue(4).ToString(), menu.GetDecimal(5));
                        FullMenu.Add(meal);
                    }
                }
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message);
            }
            finally
            {
                foreach (MenuItem meal in FullMenu)
                {
                    Console.WriteLine(meal.Item);
                }
                conn.Close();
            }
        }
    }
}
