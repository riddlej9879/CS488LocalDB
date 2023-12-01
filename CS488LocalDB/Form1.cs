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
            InsertPrepStages();
            ClearDefaultOrders();
            InsertDefaultOrders();
            ResetComponents();
            CreateOrderPanel.Visible = true;
            CreateOrderPanel.Location = new Point(12, 27);
            TrackOrderPanel.Visible = false;
            TrackOrderPanel.Location = new Point(12, 27);

            DbConnection dbc_menu = new DbConnection(new GetDatabaseMenu().QueryString);

            try
            {
                dbc_menu.Connection.Open();
                SqlDataReader menu = dbc_menu.SqlCommand.ExecuteReader();

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
                MessageBox.Show(sqlException.Message, "Form 1");
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

                    CreateOrderPanel.Controls.Add(mealPanel);
                    i++;
                }
                dbc_menu.Connection.Close();
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
                BackColor = Color.Beige,
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
            trackView.Items.Clear();
            decSubTot = 0;
            decTotal = 0;
            total.Text = "--";
            subtotal.Text = "--";
            lblTxtTrackTot.Text = "--";
            tax.Text = "--";

            return;
        }
        // Returns Customer ID
        private int GetCustID()
        {
            DbConnection dbc_custId = new DbConnection(new GetCustomerID().QueryString);

            int cust_number = 0;

            try
            {
                dbc_custId.Connection.Open();
                SqlDataReader cust_num = dbc_custId.SqlCommand.ExecuteReader();
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
                MessageBox.Show(sqlException.Message, "Sql ");
            }
            finally
            {
                dbc_custId.Connection.Close();
            }

            return cust_number;
        }
        // Returns Employee ID
        private int GetEmpID()
        {
            DbConnection dbc_empId = new DbConnection(new GetEmployeeID().QueryString);

            int emp_number = 0;

            try
            {
                dbc_empId.Connection.Open();
                SqlDataReader emp_num = dbc_empId.SqlCommand.ExecuteReader();
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
                MessageBox.Show(sqlException.Message, "GetEmpID");
            }
            finally
            {
                dbc_empId.Connection.Close();
            }

            return emp_number;
        }
        // Submits Order and returns the Order ID
        private int GetOrderID(int cust_id, int emp_id, decimal sub_tot, decimal tax, string pay_type)
        {
            int order_number = 0;
            DbConnection dbc_orderId = new DbConnection(new GetOrderID().QueryString);

            dbc_orderId.SqlCommand.Parameters.AddWithValue("@cust_id", cust_id);
            dbc_orderId.SqlCommand.Parameters.AddWithValue("@emp_id", emp_id);
            dbc_orderId.SqlCommand.Parameters.AddWithValue("@sub_tot", sub_tot);
            dbc_orderId.SqlCommand.Parameters.AddWithValue("@tax", tax);
            dbc_orderId.SqlCommand.Parameters.AddWithValue("@pay_type", pay_type);

            try
            {
                dbc_orderId.Connection.Open();
                order_number = (int)dbc_orderId.SqlCommand.ExecuteScalar();
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "GetOrderID");
            }
            finally
            {
                dbc_orderId.Connection.Close();
            }

            return order_number;
        }
        // Gets order total
        private string GetTrackTotal(int order_id)
        {
            string total = "";
            DbConnection dbc_TrackOrderTotal = new DbConnection(new TrackOrderTotal().QueryString);
            dbc_TrackOrderTotal.SqlCommand.Parameters.AddWithValue("@order_id", order_id);

            try
            {
                dbc_TrackOrderTotal.Connection.Open();
                SqlDataReader read_TrackOrderTotal = dbc_TrackOrderTotal.SqlCommand.ExecuteReader();
                while (read_TrackOrderTotal.Read())
                {
                    if (!(read_TrackOrderTotal.Equals(null)))
                    {
                        total = (Math.Round(read_TrackOrderTotal.GetDecimal(0), 2)).ToString("C");
                    }
                }
            }
            catch (SqlException SqlException)
            {
                MessageBox.Show(SqlException.Message, "GetTrackTotal");
            }
            finally
            {
                dbc_TrackOrderTotal.Connection.Close();
            }

            return total;
        }
        private void TrackOrderList(int order_id)
        {
            trackView.Items.Clear();
            ListViewItem trackItem;
            string[] trackString;
            DbConnection dbc_TrackOrderDetails = new DbConnection(new TrackOrderDetails().QueryString);
            dbc_TrackOrderDetails.SqlCommand.Parameters.AddWithValue("@order_id", order_id);

            try
            {
                dbc_TrackOrderDetails.Connection.Open();
                SqlDataReader read_TrackDet = dbc_TrackOrderDetails.SqlCommand.ExecuteReader();
                while (read_TrackDet.Read())
                {
                    if (!(read_TrackDet.Equals(null)))
                    {
                        for (int i = 0; i < read_TrackDet.FieldCount; i++)
                        {
                            trackString = new string[4]{
                                read_TrackDet.GetValue(5).ToString(),
                                read_TrackDet.GetValue(7).ToString(),
                                read_TrackDet.GetDecimal(6).ToString("0.00"),
                                (read_TrackDet.GetDecimal(6) * read_TrackDet.GetInt32(7)).ToString("C")
                            };
                            if (i == read_TrackDet.FieldCount - 1)
                            {
                                trackItem = new ListViewItem(new[]
                                {
                                    trackString[0], trackString[1], trackString[2], trackString[3]
                                });
                                trackView.Items.Add(trackItem);
                            }
                        }
                    }
                }
            }
            catch (SqlException SqlException)
            { MessageBox.Show(SqlException.Message); }
            finally
            {
                dbc_TrackOrderDetails.Connection.Close();
            }
        }

        /*************************************************************************************************/
        /*                                     Button_Click Handlers                                     */
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
                foreach (Control ctrl in pane.Controls)
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

            for (int i = 0; i < item_id.Length; i++)
            {
                ListViewItem newItem;
                MenuItem newOrder;
                foreach (MenuItem meal in FullMenu)
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

                int cust_id = GetCustID();
                int emp_id = GetEmpID();
                int order_id = GetOrderID(cust_id, emp_id, sub_tot, tax, pay_type);

                DbConnection dbc_placeOrder = new DbConnection(new PlaceOrder().QueryString);

                foreach (MenuItem newItem in FullOrder)
                {
                    dbc_placeOrder.SqlCommand.Parameters.AddWithValue("@order_id", order_id);
                    dbc_placeOrder.SqlCommand.Parameters.AddWithValue("@menu_id", newItem.Menu_id);
                    dbc_placeOrder.SqlCommand.Parameters.AddWithValue("@qty", newItem.Quantity);
                    try
                    {
                        dbc_placeOrder.Connection.Open();
                        dbc_placeOrder.SqlCommand.ExecuteNonQuery();
                    }
                    catch (SqlException sqlException)
                    {
                        MessageBox.Show(sqlException.Message, "PlaceOrder_Click");
                    }
                    finally
                    {
                        dbc_placeOrder.Connection.Close();
                        dbc_placeOrder.SqlCommand.Parameters.Clear();
                    }
                }
            }
        }
        // Customer Track Order page
        private void BtnTrackOrder_Click(object sender, EventArgs e)
        {
            lblTxtStage.Text = "--";
            lblTxtDesc.Text = "--";
            if (int.TryParse(txtOrder.Text, out int order))
            {
                string TestQuery = "select order_id, order_stages.prep_stage_id, prep_stage_name, prep_stage_desc from order_stages full join prep_stages on order_stages.prep_stage_id = prep_stages.prep_stage_id where order_id = @order_id";
                DbConnection dbc_TrackOrder = new DbConnection(TestQuery);
                dbc_TrackOrder.SqlCommand.Parameters.AddWithValue("@order_id", order);
                
                try
                {
                    dbc_TrackOrder.Connection.Open();
                    SqlDataReader read_TrackOrder = dbc_TrackOrder.SqlCommand.ExecuteReader();

                    while (read_TrackOrder.Read())
                    {
                        if (!(read_TrackOrder.Equals(null)))
                        {
                            lblTxtStage.Text = read_TrackOrder.GetString(2);
                            lblTxtDesc.Text = read_TrackOrder.GetString(3);
                            lblTxtTrackTot.Text = GetTrackTotal(order);
                            TrackOrderList(order);
                        }
                    }
                }
                catch (SqlException sqlException)
                {
                    MessageBox.Show(sqlException.Message, "BtnTrackOrder_Click");
                }
                finally
                {
                    dbc_TrackOrder.SqlCommand.Parameters.Clear();
                    dbc_TrackOrder.Connection.Close();
                }
                if (lblTxtStage.Text.Equals("--") && lblTxtDesc.Text.Equals("--"))
                {
                    MessageBox.Show("Order number not found", "No Order Number");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number", "No Order Number");
            }
        }
        // Button to get the orders stored in the database
        private void BtnGetAllDetails_Click(object sender, EventArgs e)
        {
            DbConnection dbc_getAllOrdDet = new DbConnection(new GetAllOrderDetails().QueryString);

            try
            {
                dbc_getAllOrdDet.Connection.Open();
                SqlDataReader allDetails = dbc_getAllOrdDet.SqlCommand.ExecuteReader();
                
                Console.WriteLine("");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Order_id\t\t" + "Item_id\t\t" + "Quantity");

                while (allDetails.Read())
                {
                    if (!(allDetails.Equals(null)))
                    {
                        Console.WriteLine(
                            allDetails.GetValue(0).ToString() + "\t\t\t" +
                            allDetails.GetValue(1).ToString() + "\t\t\t" +
                            allDetails.GetValue(2).ToString());
                    }
                }
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "BtnGetAllDetails_Click");
            }
            finally
            {
                dbc_getAllOrdDet.Connection.Close();
            }
        }
        // Button to get the data in order details table
        private void BtnGetAllOrders_Click(object sender, EventArgs e)
        {
            DbConnection dbc_getAllOrd = new DbConnection(new GetAllOrders().QueryString);

            try
            {
                dbc_getAllOrd.Connection.Open();
                SqlDataReader allOrders = dbc_getAllOrd.SqlCommand.ExecuteReader();

                Console.WriteLine("");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Order_id\t\t" + "Cust_id\t\t" + "Emp_id\t\t" + "Sub_Total\t\t" + "Tax\t\t\t" + "Pay");

                while (allOrders.Read())
                {
                    if (!(allOrders.Equals(null)))
                    {
                        Console.WriteLine(
                            allOrders.GetValue(0).ToString() + "\t\t\t" +
                            allOrders.GetValue(1).ToString() + "\t\t\t" +
                            allOrders.GetValue(2).ToString() + "\t\t\t" +
                            allOrders.GetDecimal(3).ToString("0.00") + "\t\t\t" +
                            allOrders.GetDecimal(4).ToString() + "\t\t" +
                            allOrders.GetValue(5).ToString().Trim());
                    }
                }
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "BtnGetAllOrders_Click");
            }
            finally
            {
                dbc_getAllOrd.Connection.Close();
            }
        }
        // Button to get all Customer IDs (Add data in the future)
        private void BtnGetAllCustIDs_Click(object sender, EventArgs e)
        {
            DbConnection dbc_getAllCustIDs = new DbConnection(new GetAllCustIDs().QueryString);

            try
            {
                dbc_getAllCustIDs.Connection.Open();
                SqlDataReader allCustIDs = dbc_getAllCustIDs.SqlCommand.ExecuteReader();

                Console.WriteLine(" ");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Cust_id");

                while (allCustIDs.Read())
                {
                    if (!(allCustIDs.Equals(null)))
                    {
                        Console.WriteLine(allCustIDs.GetValue(0).ToString());
                    }
                }
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "BtnGetAllCustIDs_Click");
            }
            finally
            {
                dbc_getAllCustIDs.Connection.Close();
            }
        }
        // Button to get all Employee IDs (Add data in the future)
        private void BtnGetAllEmpIDs_Click(object sender, EventArgs e)
        {
            DbConnection dbc_getAllEmpIDs = new DbConnection(new GetAllEmpIDs().QueryString);

            try
            {
                dbc_getAllEmpIDs.Connection.Open();
                SqlDataReader allEmpIDs = dbc_getAllEmpIDs.SqlCommand.ExecuteReader();

                Console.WriteLine(" ");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Emp_id");

                while (allEmpIDs.Read())
                {
                    if (!(allEmpIDs.Equals(null)))
                    {
                        Console.WriteLine(allEmpIDs.GetValue(0).ToString());
                    }
                }
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "BtnGetAllEmpIDs_Click");
            }
            finally
            {
                dbc_getAllEmpIDs.Connection.Close();
            }
        }
        // Button to get a list of all data in Order_Stages
        private void BtnGetAllOrderStages_Click(object sender, EventArgs e)
        {
            DbConnection dbc_getAllOrderStages = new DbConnection(new GetAllOrders().QueryString);

            try
            {
                dbc_getAllOrderStages.Connection.Open();
                SqlDataReader allOrdersStages = dbc_getAllOrderStages.SqlCommand.ExecuteReader();

                Console.WriteLine(" ");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Order_id\t\t" + "Cust_id");
                
                while (allOrdersStages.Read())
                {
                    if (!(allOrdersStages.Equals(null)))
                    {
                        Console.WriteLine(
                            allOrdersStages.GetValue(0).ToString() + "\t\t\t" +
                            allOrdersStages.GetValue(1).ToString());
                    }
                }
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "BtnGetAllOrderStages_Click");
            }
            finally
            {
                dbc_getAllOrderStages.Connection.Close();
            }
        }

        /*************************************************************************************************/
        /*                                Functions to setup initial data                                */
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
                MessageBox.Show(sqlException.Message, "ClearDefaultOrders");
            }
            finally
            {
                dbc.Connection.Close();
            }
        }
        // Inserts order stages into the database
        private void InsertPrepStages()
        {
            InsertPrepStages Stages = new InsertPrepStages();
            DbConnection dbc1 = new DbConnection(Stages.QueryString);
            DbConnection dbc2 = new DbConnection(Stages.QueryString);
            DbConnection dbc3 = new DbConnection(Stages.QueryString);
            DbConnection dbc4 = new DbConnection(Stages.QueryString);

            dbc1.SqlCommand.Parameters.AddWithValue("@id", Stages.Stage1_id);
            dbc1.SqlCommand.Parameters.AddWithValue("@name", Stages.Stage1_Name);
            dbc1.SqlCommand.Parameters.AddWithValue("@desc", Stages.Stage1_Desc);
            dbc2.SqlCommand.Parameters.AddWithValue("@id", Stages.Stage2_id);
            dbc2.SqlCommand.Parameters.AddWithValue("@name", Stages.Stage2_Name);
            dbc2.SqlCommand.Parameters.AddWithValue("@desc", Stages.Stage2_Desc);
            dbc3.SqlCommand.Parameters.AddWithValue("@id", Stages.Stage3_id);
            dbc3.SqlCommand.Parameters.AddWithValue("@name", Stages.Stage3_Name);
            dbc3.SqlCommand.Parameters.AddWithValue("@desc", Stages.Stage3_Desc);
            dbc4.SqlCommand.Parameters.AddWithValue("@id", Stages.Stage4_id);
            dbc4.SqlCommand.Parameters.AddWithValue("@name", Stages.Stage4_Name);
            dbc4.SqlCommand.Parameters.AddWithValue("@desc", Stages.Stage4_Desc);

            try
            {
                dbc1.Connection.Open();
                dbc1.SqlCommand.ExecuteNonQuery();
                dbc2.Connection.Open();
                dbc2.SqlCommand.ExecuteNonQuery();
                dbc3.Connection.Open();
                dbc3.SqlCommand.ExecuteNonQuery();
                dbc4.Connection.Open();
                dbc4.SqlCommand.ExecuteNonQuery();
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "InsertPrepStages");
            }
            finally
            {
                dbc1.Connection.Close();
                dbc2.Connection.Close();
                dbc3.Connection.Close();
                dbc4.Connection.Close();
            }
        }
        // Inserts 4 orders and associated details
        private void InsertDefaultOrders()
        {
            // Default data for orders 1 and 2 for table Orders
            List<InsertDefaultOrders> DefOrders = new List<InsertDefaultOrders>
            {   new InsertDefaultOrders(100, 1, (decimal)37.97, (decimal).1, "check"),
                new InsertDefaultOrders(100, 1, (decimal)53.98, (decimal).1, "cash"),
                new InsertDefaultOrders(100, 1, (decimal)35.49, (decimal).1, "credit"),
                new InsertDefaultOrders(100, 1, (decimal)454.80, (decimal).1, "credit")};
            DbConnection dbc_AddDefaultOrder;
            DbConnection dbc_InsertOrderStage;

            int[] stage = { 1, 4, 2, 3 };
            int order_id;
            int i = 0;
            
            foreach (InsertDefaultOrders order in DefOrders)
            {
                order_id = 0;
                dbc_AddDefaultOrder = new DbConnection(order.QueryString);
                dbc_AddDefaultOrder.SqlCommand.Parameters.AddWithValue( "@cust_id", order.Custid);
                dbc_AddDefaultOrder.SqlCommand.Parameters.AddWithValue(  "@emp_id", order.Empid);
                dbc_AddDefaultOrder.SqlCommand.Parameters.AddWithValue( "@sub_tot", order.Subtot);
                dbc_AddDefaultOrder.SqlCommand.Parameters.AddWithValue(     "@tax", order.Tax);
                dbc_AddDefaultOrder.SqlCommand.Parameters.AddWithValue("@pay_type", order.Pay);
                
                try
                {
                    dbc_AddDefaultOrder.Connection.Open();
                    order_id = (int)dbc_AddDefaultOrder.SqlCommand.ExecuteScalar();
                    dbc_InsertOrderStage = new DbConnection(new InsertOrderStages().QueryString);
                    dbc_InsertOrderStage.SqlCommand.Parameters.AddWithValue("@order_id", order_id);
                    dbc_InsertOrderStage.SqlCommand.Parameters.AddWithValue("@stage_id", stage[i]);
                    try
                    {
                        dbc_InsertOrderStage.Connection.Open();
                        dbc_InsertOrderStage.SqlCommand.ExecuteNonQuery();
                    }
                    catch (SqlException SqlException)
                    { MessageBox.Show(SqlException.Message, "InsertDefaultOrders: Order Stage"); }
                    finally
                    {
                        dbc_InsertOrderStage.SqlCommand.Parameters.Clear();
                        dbc_InsertOrderStage.Connection.Close();
                    }
                }
                catch (SqlException SqlException)
                {
                    MessageBox.Show(SqlException.Message, "InsertDefaultOrders 1");
                }
                finally
                {
                    dbc_AddDefaultOrder.SqlCommand.Parameters.Clear();
                    dbc_AddDefaultOrder.Connection.Close();
                    if(!(order_id.Equals(0)))
                    {
                        InsertDefaultOrderDetails(order_id, i);
                        i++;
                    }
                }
            }
        }
        // Insert the Order Details for the Default Orders
        private void InsertDefaultOrderDetails(int orderId, int index)
        {
            DbConnection DefDetails; // = new InsertDefaultDetails;
            List<int[,]> InitialDetails = new List<int[,]>();
            int[,] Ord1 = {  { 1, 1 },  { 3,  1 },  { 13,  1 },  { 21,  1 } };
            int[,] Ord2 = { { 13, 2 }, { 23,  1 },  { 41,  2 } };
            int[,] Ord3 = { { 13, 1 }, { 33,  1 },  { 42,  1 } };
            int[,] Ord4 = { { 3, 10 }, { 13, 10 }, { 33, 10 }, { 41, 10 } };
            InitialDetails.Add(Ord1);
            InitialDetails.Add(Ord2);
            InitialDetails.Add(Ord3);
            InitialDetails.Add(Ord4);
            int[,] CurrentOrder = InitialDetails[index];

            for (int i = 0; i < CurrentOrder.Length/2; i++)
            {
                DefDetails = new DbConnection(new InsertDefaultDetails().QueryString);
                DefDetails.SqlCommand.Parameters.AddWithValue("@order_id", orderId);
                DefDetails.SqlCommand.Parameters.AddWithValue("@menu_id", CurrentOrder[i,0]);
                DefDetails.SqlCommand.Parameters.AddWithValue("@qty", CurrentOrder[i,1]);
                try
                {
                    DefDetails.Connection.Open();
                    DefDetails.SqlCommand.ExecuteNonQuery();
                }
                catch (SqlException SqlException)
                {
                    MessageBox.Show(SqlException.Message, "InsertDefaultOrderDetails");
                }
                finally
                {
                    DefDetails.SqlCommand.Parameters.Clear();
                    DefDetails.Connection.Close();
                }
            }
        }

        /*************************************************************************************************/
        /*                               Tool Strip Menu for page changing                               */
        // Show Place Order Panel
        private void PlaceOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateOrderPanel.Visible = true;
            TrackOrderPanel.Visible = false;
        }
        // Show Track Order Panel
        private void TrackOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateOrderPanel.Visible = false;
            TrackOrderPanel.Visible = true;
        }
        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Employee panel false
        }
        // Tool Strip Menu for Employees
        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Employee panel true
        }

        private void trackView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblOrdStage_Click(object sender, EventArgs e)
        {

        }

        private void lblTrackTot_Click(object sender, EventArgs e)
        {

        }

        private void lblTxtDesc_Click(object sender, EventArgs e)
        {

        }

        private void lblTxtStage_Click(object sender, EventArgs e)
        {

        }

        private void lblDesc_Click(object sender, EventArgs e)
        {

        }

        private void txtOrder_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTrackOrder_Click(object sender, EventArgs e)
        {

        }

        private void lblTxtTrackTot_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}


