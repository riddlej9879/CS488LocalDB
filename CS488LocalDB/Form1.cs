using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Linq;

namespace CS488LocalDB
{
    public partial class Form1 : Form
    {
        // List of all items on the menu
        List<MenuItem> FullMenu = new List<MenuItem>();
        List<MenuItem> FullOrder = new List<MenuItem>();

        // Panels of each menu item
        readonly List<Panel> FoodPanels = new List<Panel>();

        //Global Variables
        readonly int innerHeight = new InnerHeight().Inner_Height;
        readonly int innerWidth = new InnerWidth().Inner_Width;
        readonly int leftMargin = new LeftMargin().Left_Margin;
        readonly int topMargin = new TopMargin().Top_Margin;

        decimal decSubTot = 0;
        decimal decTotal = 0;
        double dblTaxRate = .1;

        public Form1()
        {
            InitializeComponent();
            
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
                        MenuItem Meal = new MenuItem(
                            menu.GetInt32(0), menu.GetInt32(1),
                            menu.GetInt32(2), menu.GetValue(3).ToString(),
                            menu.GetValue(4).ToString(), menu.GetDecimal(5));
                        // Create and Add new MenuItem object
                        FullMenu.Add(Meal);

                        // Create and Add new Panel to Panel List
                        FoodPanels.Add(CreateMenuPanel(Meal));
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
                    mealPanel.BorderStyle = BorderStyle.FixedSingle;
                    mealPanel.Left = leftMargin;
                    mealPanel.Top = (((innerHeight
                        + topMargin) * i) + topMargin);

                    MenuPanel.Controls.Add(mealPanel);
                    
                    i++;
                }
                conn.Close();
            }
        }
        
        public Panel CreateMenuPanel(MenuItem Meal)
        {
            Panel newMealPanel = new Panel
            {
                Width = innerWidth,
                Height = innerHeight,
                Anchor = AnchorStyles.Left,
                BorderStyle = BorderStyle.FixedSingle,
                Visible = true
            };

            Label id = new Label
            {
                Text = Meal.Menu_id.ToString(),
                Visible = false
            };

            Label name = new Label
            {
                Text = Meal.Name,
                AutoSize = true,
                Location = new Point(4, 4),
                Anchor = (AnchorStyles.Top | AnchorStyles.Left),
                Visible = true
            };

            Label desc = new Label
            {
                Text = Meal.Desc,
                AutoSize = true,
                Location = new Point(4, 28),
                Anchor = (AnchorStyles.Bottom | AnchorStyles.Left),
                Visible = true
            };

            Label lblQty = new Label
            {
                Text = "Quantity:",
                AutoSize = true,
                Location = new Point(200, 5),
                Visible = true
            };

            Label lblMealPrice = new Label
            {
                Text = "Price:",
                AutoSize = true,
                Location = new Point(200, 40),
                Visible = true
            };

            NumericUpDown numBoxQty = new NumericUpDown
            {
                Location = new Point(260, 3),
                Value = 0,
                Width = 40,
                Height = 20,
                Visible = true,
                Tag = Meal.Menu_id.ToString()
            };

            Label mealPrice = new Label
            {
                Text = Meal.Price.ToString("C"),
                AutoSize = true,
                Location = new Point(270, 40),
                Visible = true
            };

            newMealPanel.Controls.Add(numBoxQty);
            newMealPanel.Controls.Add(id);
            newMealPanel.Controls.Add(name);
            newMealPanel.Controls.Add(desc);
            newMealPanel.Controls.Add(lblMealPrice);
            newMealPanel.Controls.Add(mealPrice);
            newMealPanel.Controls.Add(lblQty);

            return newMealPanel;
        }

        // Clears mutable fields and objects
        public void ResetComponents()
        {
            FullOrder.Clear();
            orderView.Items.Clear();
            decSubTot = 0;
            decTotal = 0;
            total.Text = "";
            subtotal.Text = "";
            tax.Text = "";

            return;
        }

        private void MakeOrder_Click(object sender, EventArgs e)
        {
            ResetComponents();

            List<int> temp_id = new List<int>();
            List<int> temp_qty = new List<int>();
            int[] item_id;
            int[] item_qty;

            foreach (Panel pane in FoodPanels)
            {
                int val = 0;
                foreach(Control ctrl in pane.Controls)
                {
                    if (ctrl is NumericUpDown num)
                    {
                        val = (int)(num.Value);
                        if (val > 0)
                        {
                            temp_id.Add(Int32.Parse(ctrl.Tag.ToString()));
                            temp_qty.Add(Int32.Parse(val.ToString()));
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            item_id = temp_id.ToArray();
            item_qty = temp_qty.ToArray();

            for(int i =0; i < item_id.Length; i++)
            {
                ListViewItem newItem = null;
                MenuItem newOrder = null;
                foreach(MenuItem meal in FullMenu)
                {
                    if (meal.Menu_id == item_id[i])
                    {
                        newOrder = new MenuItem(meal.Menu_id, meal.Sub_id,
                            meal.Cat_id, meal.Desc, meal.Name, meal.Price, item_qty[i]);
                        FullOrder.Add(newOrder);

                        newItem = new ListViewItem(new[]
                        {
                            meal.Name, item_qty[i].ToString(),
                            meal.Price.ToString("0.00"),
                            (item_qty[i] * meal.Price).ToString("C")
                        });
                        orderView.Items.Add(newItem);

                        decSubTot += (item_qty[i] * meal.Price);
                    }
                }
            }
            subtotal.Text = decSubTot.ToString("C");
            tax.Text = (decSubTot * (decimal)dblTaxRate).ToString("C");
            total.Text = (decSubTot + (decSubTot * (decimal)dblTaxRate)).ToString("C");
        }

        private void placeOrder_Click(object sender, EventArgs e)
        {

        }
    }
}


