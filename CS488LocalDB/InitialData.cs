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
            this.QueryString = query_string;
            SqlCommand = new SqlCommand(query_string, Connection);
        }
        public Env ConnectionString { get; }
        public string ServerConnection { get; }
        public SqlConnection Connection { get; }
        public string QueryString { get; }
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
        public InsertDefaultDetails(int item_id, int qty)
        {
            QueryString = "insert into order_details values(@order_id, @menu_id, @qty)";
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
            QueryString = "insert into prep_stages values(@id, @name, @desc)";
            // Stage 1 Prep
            Stage1_id = 1;
            Stage1_Name = "Prepping";
            Stage1_Desc = "This order is being prepared";
            // Stage 2 Bake
            Stage2_id = 2;
            Stage2_Name = "Baking";
            Stage2_Desc = "This order is currently baking";
            // Stage 3 Ready
            Stage3_id = 3;
            Stage3_Name = "Ready";
            Stage3_Desc = "This order is ready for pick up";
            // Stage 4 Complete
            Stage4_id = 4;
            Stage4_Name = "Complete";
            Stage4_Desc = "This order has been picked up";
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
        public int Stage4_id { get; }
        public string Stage4_Name { get; }
        public string Stage4_Desc { get; }
    }
    class InsertOrderStages
    {
        public InsertOrderStages()
        {
            QueryString = "insert into order_stages values(@order_id, @stage_id)";
        }
        public string QueryString { get; }
    }
    class GetDatabaseMenu
    {
        public GetDatabaseMenu()
        {
            QueryString = "select MENU_ITEM_ID, MENU_ITEMS.PRODUCT_SUB_ID, PRODUCT_CAT.CATEGORY_ID, PRODUCT_CAT.DESCRIPTION, PRODUCT_SUB.DESCRIPTION, ITEM_PRICE from menu_items inner join PRODUCT_SUB on menu_items.PRODUCT_SUB_ID = PRODUCT_SUB.PRODUCT_SUB_ID inner join PRODUCT_CAT on PRODUCT_SUB.CATEGORY_ID = PRODUCT_CAT.CATEGORY_ID";
        }
        public string QueryString { get; }
    }
    class GetCustomerID
    {
        public GetCustomerID()
        {
            QueryString = "select top 1 customer_id from customers";
        }
        public string QueryString { get; }
    }
    class GetEmployeeID
    {
        public GetEmployeeID()
        {
            QueryString = "select top 1 employee_id from employees";
        }
        public string QueryString { get; }
    }
    class GetOrderID
    {
        public GetOrderID()
        {
            QueryString = "insert into orders output inserted.order_id values(@cust_id, @emp_id, @sub_tot, @tax, @pay_type)";
        }
        public string QueryString { get; }
    }
    class PlaceOrder
    {
        public PlaceOrder()
        {
            QueryString = "insert into order_details values(@order_id, @menu_id, @qty)";
        }
        public string QueryString { get; }
    }
    class GetAllOrderDetails
    {
        public GetAllOrderDetails()
        {
            QueryString = "select * from order_details";
        }
        public string QueryString { get; }
    }
    class GetAllOrders
    {
        public GetAllOrders()
        {
            QueryString = "select * from orders";
        }
        public string QueryString { get; }
    }
    class GetAllOrderStages
    {
        public GetAllOrderStages()
        {
            QueryString = "select * from order_stages where order_id = @order_id";
        }
        public string QueryString { get; }
    }
    class GetAllCustIDs
    {
        public GetAllCustIDs()
        {
            QueryString = "select customer_id from customers";
        }
        public string QueryString { get; }
    }
    class GetAllEmpIDs
    {
        public GetAllEmpIDs()
        {
            QueryString = "select employee_id from employees";
        }
        public string QueryString { get; }
    }
    class TrackOrder
    {
        public TrackOrder()
        {               
            QueryString = "select order_id, order_stages.prep_stage_id, prep_stage_name, prep_stage_desc " +
                "from order_stages full join prep_stages on order_stages.prep_stage_id = prep_stages.prep_stage_id " +
                "where (order_id = @order_id) and order_stages.prep_stage_id = " +
                "(select max(prep_stage_id) from order_stages) " +
                "group by order_id, order_stages.prep_stage_id, prep_stage_name, prep_stage_desc";
        }
        public string QueryString { get; }
    }
    class TrackOrderTotal
    {
        public TrackOrderTotal()
        {
            QueryString = "select (subtotal + (subtotal * tax_rate)) from orders where order_id = @order_id";
        }
        public string QueryString { get; }
    }
    class TrackOrderDetails
    {
        public TrackOrderDetails()
        {
            QueryString = "select order_id, order_details.menu_item_id, menu_items.product_sub_id, product_cat.category_id,product_cat.description, product_sub.description, item_price, quantity " +
                "from order_details inner join menu_items on order_details.menu_item_id = menu_items.menu_item_id " +
                "inner join product_sub on menu_items.product_sub_id = product_sub.product_sub_id " +
                "inner join product_cat on product_sub.category_id = product_cat.category_id where order_id = @order_id";
        }
        public string QueryString { get; }
    }
}

