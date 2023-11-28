using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

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
            ClearDefaultOrders();
            InsertDefaultData();
            InsertPrepStages();
            ResetComponents();
            MenuPanel.Visible = true;

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
        // Button to get the orders stored in the database
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
        // Button to get the data in order details table
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
        // Deletes the orders already in the database
        private void ClearDefaultOrders()
        {
            ClearOrders clear = new ClearOrders();
            DbConnection dbc = new DbConnection(clear.Clear_Default_Orders);

            try
            {
                dbc.Connection.Open();
                dbc.SqlCommand.ExecuteNonQuery();
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message);
            }
            finally
            {
                dbc.Connection.Close();
            }
        }
        // Inserts 2 orders and associated details
        private void InsertDefaultData()
        {
            List<InsertDefaultDetails> defdet1 = new List<InsertDefaultDetails>();
            List<InsertDefaultDetails> defdet2 = new List<InsertDefaultDetails>();
            InsertDefaultOrders deford1 = new
                InsertDefaultOrders(100, 1, (decimal)37.97, (decimal).1, "check");
            InsertDefaultOrders deford2 = new
                InsertDefaultOrders(100, 1, (decimal)53.98, (decimal).1, "cash");
            DbConnection dbc1 = new DbConnection(deford1.QueryString);
            dbc1.SqlCommand.Parameters.AddWithValue("@cust_id", deford1.Custid);
            dbc1.SqlCommand.Parameters.AddWithValue("@emp_id", deford1.Empid);
            dbc1.SqlCommand.Parameters.AddWithValue("@sub_tot", deford1.Subtot);
            dbc1.SqlCommand.Parameters.AddWithValue("@tax", deford1.Tax);
            dbc1.SqlCommand.Parameters.AddWithValue("@pay_type", deford1.Pay);
            DbConnection dbc2 = new DbConnection(deford2.QueryString);
            dbc2.SqlCommand.Parameters.AddWithValue("@cust_id", deford2.Custid);
            dbc2.SqlCommand.Parameters.AddWithValue("@emp_id", deford2.Empid);
            dbc2.SqlCommand.Parameters.AddWithValue("@sub_tot", deford2.Subtot);
            dbc2.SqlCommand.Parameters.AddWithValue("@tax", deford2.Tax);
            dbc2.SqlCommand.Parameters.AddWithValue("@pay_type", deford2.Pay);

            int dbc1_OrdID = 0;
            int dbc2_OrdID = 0;

            try
            {
                dbc1.Connection.Open();
                dbc1_OrdID = (int)dbc1.SqlCommand.ExecuteScalar();
                dbc2.Connection.Open();
                dbc2_OrdID = (int)dbc2.SqlCommand.ExecuteScalar();
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message);
            }
            finally
            {
                dbc1.Connection.Close();
                dbc2.Connection.Close();
            }

            if ((dbc1_OrdID > 0) && (dbc2_OrdID > 0))
            {
                DbConnection dbc3 = new DbConnection(new InsertDefaultDetails().QueryString);
                // Order 1 details
                defdet1.Add(new InsertDefaultDetails((int)dbc1_OrdID, 1, 1));
                defdet1.Add(new InsertDefaultDetails((int)dbc1_OrdID, 3, 1));
                defdet1.Add(new InsertDefaultDetails((int)dbc1_OrdID, 13, 1));
                defdet1.Add(new InsertDefaultDetails((int)dbc1_OrdID, 21, 1));
                // Order 2 details
                defdet2.Add(new InsertDefaultDetails((int)dbc2_OrdID, 13, 2));
                defdet2.Add(new InsertDefaultDetails((int)dbc2_OrdID, 23, 1));
                defdet2.Add(new InsertDefaultDetails((int)dbc2_OrdID, 41, 2));

                // Order 1 details
                foreach (InsertDefaultDetails det in defdet1)
                {
                    dbc3.SqlCommand.Parameters.AddWithValue("@order_id", det.Orderid);
                    dbc3.SqlCommand.Parameters.AddWithValue("@menu_id", det.Itemid);
                    dbc3.SqlCommand.Parameters.AddWithValue("@qty", det.Qty);
                    try
                    {
                        dbc3.Connection.Open();
                        dbc3.SqlCommand.ExecuteNonQuery();
                    }
                    catch (SqlException sqlException)
                    {
                        MessageBox.Show(sqlException.Message);
                    }
                    finally
                    {
                        dbc3.SqlCommand.Parameters.Clear();
                        dbc3.Connection.Close();
                    }
                }
                // Order 2 details
                foreach (InsertDefaultDetails det in defdet2)
                {
                    dbc3.SqlCommand.Parameters.AddWithValue("@order_id", det.Orderid);
                    dbc3.SqlCommand.Parameters.AddWithValue("@menu_id", det.Itemid);
                    dbc3.SqlCommand.Parameters.AddWithValue("@qty", det.Qty);
                    try
                    {
                        dbc3.Connection.Open();
                        dbc3.SqlCommand.ExecuteNonQuery();
                    }
                    catch (SqlException sqlException)
                    {
                        MessageBox.Show(sqlException.Message);
                    }
                    finally
                    {
                        dbc3.SqlCommand.Parameters.Clear();
                        dbc3.Connection.Close();
                    }
                }
            }
        }
        // Inserts order stages into the database
        private void InsertPrepStages()
        {
            InsertPrepStages stages = new InsertPrepStages();
            DbConnection dbc1 = new DbConnection(stages.QueryString);
            DbConnection dbc2 = new DbConnection(stages.QueryString);
            DbConnection dbc3 = new DbConnection(stages.QueryString);

            dbc1.SqlCommand.Parameters.AddWithValue("@id", stages.Stage1_id);
            dbc1.SqlCommand.Parameters.AddWithValue("@name", stages.Stage1_Name);
            dbc1.SqlCommand.Parameters.AddWithValue("@desc", stages.Stage1_Desc);
            dbc2.SqlCommand.Parameters.AddWithValue("@id", stages.Stage2_id);
            dbc2.SqlCommand.Parameters.AddWithValue("@name", stages.Stage2_Name);
            dbc2.SqlCommand.Parameters.AddWithValue("@desc", stages.Stage2_Desc);
            dbc3.SqlCommand.Parameters.AddWithValue("@id", stages.Stage3_id);
            dbc3.SqlCommand.Parameters.AddWithValue("@name", stages.Stage3_Name);
            dbc3.SqlCommand.Parameters.AddWithValue("@desc", stages.Stage3_Desc);

            try
            {
                dbc1.Connection.Open();
                dbc2.Connection.Open();
                dbc3.Connection.Open();
                dbc1.SqlCommand.ExecuteNonQuery();
                dbc2.SqlCommand.ExecuteNonQuery();
                dbc3.SqlCommand.ExecuteNonQuery();
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message);
            }
            finally
            {
                dbc1.Connection.Close();
                dbc2.Connection.Close();
                dbc3.Connection.Close();
            }
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPanel.Visible = true;
            // Employee panel false
        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPanel.Visible = false;
            // Employee panel true
        }
    }
}


