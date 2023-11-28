using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Linq;
using System.Collections;

namespace CS488LocalDB
{
    public partial class Form1 : Form
    {
        // List of all items on the menu
        readonly List<MenuItem> FullMenu = new List<MenuItem>();
        readonly List<MenuItem> FullOrder = new List<MenuItem>();

        // Panels of each menu item
        readonly List<Panel> FoodPanels = new List<Panel>();

        //Global Variables
        readonly int innerHeight = new InnerHeight().Inner_Height;
        readonly int innerWidth = new InnerWidth().Inner_Width;
        readonly int leftMargin = new LeftMargin().Left_Margin;
        readonly int topMargin = new TopMargin().Top_Margin;

        decimal decSubTot = 0;
        decimal decTotal = 0;
        readonly double dblTaxRate = .1;

        public Form1()
        {
            InitializeComponent();
            ResetComponents();

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
                        + topMargin) * i) + topMargin +20);

                    MenuPanel.Controls.Add(mealPanel);
                    
                    i++;
                }
                conn.Close();
            }
        }
        
        // Creates panels to display items available to order
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
                Minimum = 0,
                Maximum = 10,
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
            total.Text = "--";
            subtotal.Text = "--";
            tax.Text = "--";

            return;
        }

        // Creates list of items with values greater than 0
        private void CreateOrder_Click(object sender, EventArgs e)
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
                ListViewItem newItem;
                MenuItem newOrder;
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
            decTotal = (decSubTot + (decSubTot * (decimal)dblTaxRate));
            total.Text = decTotal.ToString("C");
        }

        // Sends ordered items to the database
        private void PlaceOrder_Click(object sender, EventArgs e)
        {
            if (FullOrder.Count <= 0)
            {
                MessageBox.Show(
                    "Click \"Add To Order\" to add your selected items.",
                    "No items ordered");
            }
            else if ((!radioCash.Checked && !radioCheck.Checked && !radioCredit.Checked))
            {
                MessageBox.Show(
                    "Please select a payment method to continue.",
                    "No Payment Selected");
            }
            else
            {
                decimal sub_tot = decSubTot;
                decimal tax = (decimal)dblTaxRate;
                string pay_type = paymentBox.Controls.OfType<RadioButton>()
                    .FirstOrDefault(r => r.Checked).Text;

                Env DataLocation = new Env();

                int cust_id = GetCustID();
                int emp_id = GetEmpID();
                int order_id = GetOrderID(cust_id, emp_id, sub_tot, tax, pay_type);

                foreach (MenuItem newItem in FullOrder)
                {
                    string ConnString = DataLocation.SrvConn;
                    string QueryString = "insert into order_details values(@order_id, @menu_id, @qty)";
                    using (SqlConnection connection = new SqlConnection(ConnString))
                    {
                        SqlCommand get_command = new SqlCommand(QueryString, connection);
                        get_command.Parameters.AddWithValue("@order_id", order_id);
                        get_command.Parameters.AddWithValue("@menu_id", newItem.Menu_id);
                        get_command.Parameters.AddWithValue("@qty", newItem.Quantity);

                        get_command.Connection.Open();
                        get_command.ExecuteNonQuery();
                    }
                }
                //MessageBox.Show("Order placed successfully.", "Success");
            }
        }

        // Returns Customer ID
        private int GetCustID()
        {
            Env ConnString = new Env();
            string ServerConn = ConnString.SrvConn;
            SqlConnection conn = new SqlConnection(connectionString: ServerConn);

            int cust_number = 0;

            try
            {
                SqlCommand get_cust_num = new SqlCommand("select top 1 customer_id from customers", conn);
                conn.Open();
                SqlDataReader cust_num = get_cust_num.ExecuteReader();

                while (cust_num.Read())
                {
                    if (!(cust_num.Equals(null)))
                    {
                        cust_number = cust_num.GetInt32(0);
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

            return cust_number;
        }

        // Returns Employee ID
        private int GetEmpID()
        {
            Env ConnString = new Env();
            string ServerConn = ConnString.SrvConn;
            SqlConnection conn = new SqlConnection(connectionString: ServerConn);

            int emp_number = 0;

            try
            {
                SqlCommand get_emp_num = new SqlCommand("select top 1 employee_id from employees", conn);
                conn.Open();
                SqlDataReader emp_num = get_emp_num.ExecuteReader();

                while (emp_num.Read())
                {
                    if (!(emp_num.Equals(null)))
                    {
                        emp_number = emp_num.GetInt32(0);
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

            return emp_number;
        }

        // Submits Order and returns the Order ID
        private int GetOrderID(int cust_id, int emp_id, decimal sub_tot, decimal tax, string pay_type)
        {
            int order_number = 0;
            Env DataLocation = new Env();
            string ConnString = DataLocation.SrvConn;
            string QueryString = "insert into orders output inserted.order_id values(@cust_id, @emp_id, @sub_tot, @tax, @pay_type)";
            using (SqlConnection connection = new SqlConnection(ConnString))
            {
                SqlCommand get_command = new SqlCommand(QueryString, connection);
                get_command.Parameters.AddWithValue("@cust_id", cust_id);
                get_command.Parameters.AddWithValue("@emp_id", emp_id);
                get_command.Parameters.AddWithValue("@sub_tot", sub_tot);
                get_command.Parameters.AddWithValue("@tax", tax);
                get_command.Parameters.AddWithValue("@pay_type", pay_type);

                get_command.Connection.Open();
                // is returning 1 row affected and not order_id
                //string thing = 1;
                order_number = (int)get_command.ExecuteScalar();
            }

            return order_number;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Env DatabaseLocation = new Env();
            string ConnectionString = DatabaseLocation.SrvConn;
            SqlConnection conn = new SqlConnection(connectionString: ConnectionString);

            try
            {
                SqlCommand get_details = new SqlCommand("select * from order_details", conn);
                conn.Open();
                SqlDataReader details = get_details.ExecuteReader();

                Console.WriteLine(" ");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Order_id\t\t" + "Item_id\t\t" + "Quantity");

                while (details.Read())
                {
                    if (!(details.Equals(null)))
                    {
                        Console.WriteLine(
                            details.GetValue(0).ToString() + "\t\t\t" +
                            details.GetValue(1).ToString() + "\t\t\t" +
                            details.GetValue(2).ToString());
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

        private void Button3_Click(object sender, EventArgs e)
        {
            Env DatabaseLocation = new Env();
            string ConnectionString = DatabaseLocation.SrvConn;
            SqlConnection conn = new SqlConnection(connectionString: ConnectionString);

            try
            {
                SqlCommand get_orders = new SqlCommand("select * from orders", conn);
                conn.Open();
                SqlDataReader orders = get_orders.ExecuteReader();

                Console.WriteLine(" ");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Order_id\t\t" + "Cust_id\t\t" + "Emp_id\t\t" + "Sub_Total\t\t" + "Tax\t\t\t" + "Pay");
                while (orders.Read())
                {
                    if (!(orders.Equals(null)))
                    {
                        Console.WriteLine(
                            orders.GetValue(0).ToString() + "\t\t\t" + orders.GetValue(1).ToString() + "\t\t\t" +
                            orders.GetValue(2).ToString() + "\t\t\t" + orders.GetDecimal(3).ToString("0.00") + "\t\t\t" +
                            orders.GetValue(4).ToString() + "\t\t" + orders.GetValue(5).ToString());
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

        private void DeleteOrders(object sender, EventArgs e)
        {
            //MenuPanel.Visible = false;
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPanel.Visible = true;
            // Employee panel false
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPanel.Visible = false;
            // Employee panel true
        }
    }
}


