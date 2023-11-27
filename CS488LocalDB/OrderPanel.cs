using System;
using System.Drawing;
using System.Windows.Forms;

public class OrderPanel12 : Panel
{
    /*
    public OrderPanel12()
    {
        Location = new System.Drawing.Point(12, 12);
        Width = 400;
        Height = 426;
        BorderStyle = BorderStyle.FixedSingle;
        AutoScroll = true;
        AutoSize = false;
    }

    private const int leftMargin = 4;
    private const int topMargin = 3;
    private const int innerPanelWidth = 391;
    private const int innerPanelHeight = 60;

    public static Panel AddMenuPanel(MenuItem Meal)
    {
        Panel newMenuPanel = new Panel();
        CreateMenuPanel(Meal);

        return newMenuPanel;
    }

    public static Panel CreateMenuPanel(MenuItem Meal)
    {
        Panel newMealPanel = new Panel
        {
            Width = innerPanelWidth,
            Height = innerPanelHeight,
            Anchor = AnchorStyles.Left,
            BorderStyle = BorderStyle.FixedSingle,
            Visible = true
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

        Label lblMealPrice = new Label
        {
            Text = "Price:",
            AutoSize = true,
            Location = new Point(220, 23),
            Visible = true
        };

        Label mealPrice = new Label
        {
            Text = Meal.Price.ToString("C"),
            AutoSize = true,
            Location = new Point(280, 23),
            Visible = true
        };

        Button addToOrder = new Button
        {
            Text = "Add to Order",
            Location = new Point(334, 4),
            Size = new Size(50, 50),
            Anchor = AnchorStyles.Right
        };
        addToOrder.Click += new EventHandler(Meal.AddToOrder);

        newMealPanel.Controls.Add(name);
        newMealPanel.Controls.Add(desc);
        newMealPanel.Controls.Add(lblMealPrice);
        newMealPanel.Controls.Add(mealPrice);
        newMealPanel.Controls.Add(addToOrder);

        return newMealPanel;
    }
    */
}

