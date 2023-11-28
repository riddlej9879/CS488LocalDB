using System.Data.SqlClient;

namespace CS488LocalDB
{
    class DbConnection
    {
        public DbConnection(string query_string)
        {
            ConnectionString = new Env();
            ServerConnection = ConnectionString.SrvConn;
            Connection = new SqlConnection(connectionString: ServerConnection);
            this.Query_string = query_string;
            SqlCommand = new SqlCommand(query_string, Connection);
        }
        public Env ConnectionString { get; }
        public string ServerConnection { get; }
        public SqlConnection Connection { get; }
        public string Query_string { get; }
        public SqlCommand SqlCommand { get; }
    }
    class ClearOrders
    {
        public ClearOrders()
        {
            Clear_Default_Orders = "Delete from Orders";
        }
        public string Clear_Default_Orders { get; }
    }
    class InsertDefaultOrders
    {
        public InsertDefaultOrders(int cust_id, int emp_id, decimal sub, decimal tax, string pay)
        {
            QueryString = "insert into orders output inserted.order_id values(@cust_id, @emp_id, @sub_tot, @tax, @pay_type)";
            Custid = cust_id;
            Empid = emp_id;
            Subtot = sub;
            Tax = tax;
            Pay = pay;
        }
        public int Custid { get; }
        public int Empid { get; }
        public decimal Subtot { get; }
        public decimal Tax { get; }
        public string Pay { get; }
        public string QueryString { get; }
    }
    class InsertDefaultDetails
    {
        public InsertDefaultDetails(int order_id, int item_id, int qty)
        {
            QueryString = "insert into order_details values(@order_id, @menu_id, @qty)";
            Orderid = order_id;
            Itemid = item_id;
            Qty = qty;
        }
        public InsertDefaultDetails()
        {
            QueryString = "insert into order_details values(@order_id, @menu_id, @qty)";
        }
        public int Orderid { get; }
        public int Itemid { get; }
        public int Qty { get; }
        public string QueryString { get; }
    }
    class InsertPrepStages
    {
        public InsertPrepStages()
        {
            QueryString = "insert into stages values(@id, @name, @desc)";
            // Stage 1 Prep
            Stage1_id = 1;
            Stage1_Name = "Prepping";
            Stage1_Desc = "The cooks are getting your order ready";
            // Stage 2 Bake
            Stage2_id = 2;
            Stage2_Name = "Baking";
            Stage2_Desc = "Right now your order is baking in the oven";
            // Stage 3 Ready
            Stage3_id = 3;
            Stage3_Name = "Ready";
            Stage3_Desc = "Your order is ready for pick up";
        }
        public string QueryString { get; }
        public int Stage1_id { get; }
        public string Stage1_Name { get; }
        public string Stage1_Desc { get; }
        public int Stage2_id { get; }
        public string Stage2_Name { get; }
        public string Stage2_Desc { get; }
        public int Stage3_id { get; }
        public string Stage3_Name { get; }
        public string Stage3_Desc { get; }
    }
}

/*
 * DEFAULT ORDER AND ORDER_DETAILS
--------------------------------------------------------------------------
Order_id		Cust_id		Emp_id		Sub_Total		Tax			Pay
1006			100			1			37.97			0.10		Check

Order_id		Item_id		Quantity
1006			1			1
1006			3			1
1006			13			1
1006			21			1

--------------------------------------------------------------------------
Order_id		Cust_id		Emp_id		Sub_Total		Tax			Pay
1006			100			1			53.98			0.10		Cash

Order_id		Item_id		Quantity
1006			13			2
1006			23			1
1006			41			2
*/

