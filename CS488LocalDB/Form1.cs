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
            // Use existing mealPanel as template
            // Create a list of Panels. Copy the template with new data
            List<Panel> FoodPanels = new List<Panel>();

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

                        Panel mealPanel = new Panel();
                        mealPanel.Width = 338;
                        mealPanel.Height = 60;
                        mealPanel.Anchor = AnchorStyles.Left;
                        mealPanel.BorderStyle = BorderStyle.FixedSingle;
                        mealPanel.Visible = true;


                        Label name = new Label();
                        name.Text = meal.Name;
                        name.AutoSize = true;
                        name.Location = new Point(4, 4);
                        name.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                        name.Visible = true;

                        Label desc = new Label();
                        desc.Text = meal.Desc;
                        desc.AutoSize = true;
                        desc.Location = new Point(4, 28);
                        desc.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
                        desc.Visible = true;

                        Label price = new Label();
                        price.Text = meal.Price.ToString();
                        price.AutoSize = true;
                        price.Location = new Point(226, 23);
                        price.Visible = true;

                        Button addToOrder = new Button();
                        addToOrder.Text = "Add to Order";
                        addToOrder.Location = new Point(283, 4);
                        addToOrder.Size = new Size(50, 50);
                        addToOrder.Anchor = AnchorStyles.Right;
                        addToOrder.Click += new EventHandler(meal.AddToOrder);

                        mealPanel.Controls.Add(name);
                        mealPanel.Controls.Add(desc);
                        mealPanel.Controls.Add(price);
                        mealPanel.Controls.Add(addToOrder);

                        FoodPanels.Add(mealPanel);
                    }
                }
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message);
            }
            finally
            {
                int i = 0;
                foreach (Panel mealPanel in FoodPanels)
                {
                    MenuPanel.SuspendLayout();
                    MenuPanel.Controls.Add(mealPanel);
                    mealPanel.Top = ((63 * i) + 3);

                    i++;
                }
                //MenuPanel.AutoScroll = true;
                //MenuPanel.Update();
                conn.Close();
            }
        }

        public void addNewPanel(MenuItem meal)
        {
            MenuItem panelMeal;
            panelMeal = new MenuItem(meal.Menu_id, meal.Sub_id,
                meal.Cat_id, meal.Desc, meal.Name, meal.Price);

            return;
        }
    }
}
