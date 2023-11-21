using System;
using System.Windows.Forms;

public class MenuItem
{
    public MenuItem(int menu_id, int sub_id, int cat_id, string desc, string name, decimal price)
    {
        this.Menu_id = menu_id;
        this.Sub_id = sub_id;
        this.Cat_id = cat_id;
        this.Desc = desc;
        this.Name = name;
        this.Price = price;
    }
    
    public int Menu_id { get; private set; }
    public int Sub_id { get; private set; }
    public int Cat_id { get; private set; }
    public string Desc { get; private set; }
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public void AddToOrder(int menu_id)
    {
        int num = menu_id;
        Console.WriteLine(num);
        return;
    }
    public void AddToOrder(object sender, EventArgs e)
    {
        Console.WriteLine(sender);
        Console.WriteLine(e);
        return;
    }
    
}


