using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class MenuItem
{
    // This constructor creates an object from the returned SQL data
    public MenuItem(int menu_id, int sub_id, int cat_id, string desc, string name, decimal price)
    {
        this.Menu_id = menu_id;
        this.Sub_id = sub_id;
        this.Cat_id = cat_id;
        this.Desc = desc;
        this.Name = name;
        this.Price = price;
    }
    // This constructor creates an object from the AddToOrder button, includes quantity ordered
    public MenuItem(int menu_id, int sub_id, int cat_id, string desc, string name, decimal price, int qty)
    {
        this.Menu_id = menu_id;
        this.Sub_id = sub_id;
        this.Cat_id = cat_id;
        this.Desc = desc;
        this.Name = name;
        this.Price = price;
        this.Quantity = qty;
    }
    
    public int Menu_id { get; private set; }
    public int Sub_id { get; private set; }
    public int Cat_id { get; private set; }
    public string Desc { get; private set; }
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public int Quantity { get; private set; }
    public void AddToOrder(int menu_id)
    {
        int num = menu_id;
        Console.WriteLine(num);
        return;
    }
    /*
    public void AddToOrder(object sender, EventArgs e)
    {
        int initial_quantity = 1;

        OrderItem Order = new OrderItem(
            this.Menu_id, this.Sub_id,
            this.Cat_id, this.Desc,
            this.Name, initial_quantity,
            this.Price
            );

        return;
    }
    */
}
