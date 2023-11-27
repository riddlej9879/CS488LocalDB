
namespace CS488LocalDB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mealPanel12 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.numBoxQty = new System.Windows.Forms.NumericUpDown();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblMenuPrice = new System.Windows.Forms.Label();
            this.mealPrice = new System.Windows.Forms.Label();
            this.mealDesc = new System.Windows.Forms.Label();
            this.mealName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.qty = new System.Windows.Forms.Label();
            this.lblOrderPrice = new System.Windows.Forms.Label();
            this.lblQty1 = new System.Windows.Forms.Label();
            this.orderPrice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.makeOrder = new System.Windows.Forms.Button();
            this.placeOrder = new System.Windows.Forms.Button();
            this.orderView = new System.Windows.Forms.ListView();
            this.viewName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubTot = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.mealPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxQty)).BeginInit();
            this.panel2.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mealPanel12
            // 
            this.mealPanel12.AutoScroll = true;
            this.mealPanel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mealPanel12.Controls.Add(this.button2);
            this.mealPanel12.Controls.Add(this.numBoxQty);
            this.mealPanel12.Controls.Add(this.lblQty);
            this.mealPanel12.Controls.Add(this.lblMenuPrice);
            this.mealPanel12.Controls.Add(this.mealPrice);
            this.mealPanel12.Controls.Add(this.mealDesc);
            this.mealPanel12.Controls.Add(this.mealName);
            this.mealPanel12.Location = new System.Drawing.Point(4, 3);
            this.mealPanel12.Name = "mealPanel12";
            this.mealPanel12.Size = new System.Drawing.Size(400, 200);
            this.mealPanel12.TabIndex = 1;
            this.mealPanel12.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // numBoxQty
            // 
            this.numBoxQty.Location = new System.Drawing.Point(260, 3);
            this.numBoxQty.Name = "numBoxQty";
            this.numBoxQty.Size = new System.Drawing.Size(40, 20);
            this.numBoxQty.TabIndex = 7;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(200, 5);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(49, 13);
            this.lblQty.TabIndex = 6;
            this.lblQty.Text = "Quantity:";
            // 
            // lblMenuPrice
            // 
            this.lblMenuPrice.AutoSize = true;
            this.lblMenuPrice.Location = new System.Drawing.Point(200, 40);
            this.lblMenuPrice.Name = "lblMenuPrice";
            this.lblMenuPrice.Size = new System.Drawing.Size(34, 13);
            this.lblMenuPrice.TabIndex = 5;
            this.lblMenuPrice.Text = "Price:";
            // 
            // mealPrice
            // 
            this.mealPrice.AutoSize = true;
            this.mealPrice.Location = new System.Drawing.Point(270, 40);
            this.mealPrice.Name = "mealPrice";
            this.mealPrice.Size = new System.Drawing.Size(30, 13);
            this.mealPrice.TabIndex = 3;
            this.mealPrice.Text = "price";
            // 
            // mealDesc
            // 
            this.mealDesc.AutoSize = true;
            this.mealDesc.Location = new System.Drawing.Point(4, 28);
            this.mealDesc.Name = "mealDesc";
            this.mealDesc.Size = new System.Drawing.Size(30, 13);
            this.mealDesc.TabIndex = 1;
            this.mealDesc.Text = "desc";
            // 
            // mealName
            // 
            this.mealName.AutoSize = true;
            this.mealName.Location = new System.Drawing.Point(4, 5);
            this.mealName.Name = "mealName";
            this.mealName.Size = new System.Drawing.Size(33, 13);
            this.mealName.TabIndex = 0;
            this.mealName.Text = "name";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.qty);
            this.panel2.Controls.Add(this.lblOrderPrice);
            this.panel2.Controls.Add(this.lblQty1);
            this.panel2.Controls.Add(this.orderPrice);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(3, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 60);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // qty
            // 
            this.qty.AutoSize = true;
            this.qty.Location = new System.Drawing.Point(264, 4);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(21, 13);
            this.qty.TabIndex = 6;
            this.qty.Text = "qty";
            // 
            // lblOrderPrice
            // 
            this.lblOrderPrice.AutoSize = true;
            this.lblOrderPrice.Location = new System.Drawing.Point(206, 39);
            this.lblOrderPrice.Name = "lblOrderPrice";
            this.lblOrderPrice.Size = new System.Drawing.Size(34, 13);
            this.lblOrderPrice.TabIndex = 5;
            this.lblOrderPrice.Text = "Price:";
            // 
            // lblQty1
            // 
            this.lblQty1.AutoSize = true;
            this.lblQty1.Location = new System.Drawing.Point(206, 4);
            this.lblQty1.Name = "lblQty1";
            this.lblQty1.Size = new System.Drawing.Size(49, 13);
            this.lblQty1.TabIndex = 4;
            this.lblQty1.Text = "Quantity:";
            // 
            // orderPrice
            // 
            this.orderPrice.AutoSize = true;
            this.orderPrice.Location = new System.Drawing.Point(264, 39);
            this.orderPrice.Name = "orderPrice";
            this.orderPrice.Size = new System.Drawing.Size(30, 13);
            this.orderPrice.TabIndex = 3;
            this.orderPrice.Text = "price";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "desc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "name";
            // 
            // MenuPanel
            // 
            this.MenuPanel.AutoScroll = true;
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel.Controls.Add(this.lblTotal);
            this.MenuPanel.Controls.Add(this.total);
            this.MenuPanel.Controls.Add(this.subtotal);
            this.MenuPanel.Controls.Add(this.lblTax);
            this.MenuPanel.Controls.Add(this.lblSubTot);
            this.MenuPanel.Controls.Add(this.tax);
            this.MenuPanel.Controls.Add(this.orderView);
            this.MenuPanel.Controls.Add(this.placeOrder);
            this.MenuPanel.Controls.Add(this.makeOrder);
            this.MenuPanel.Controls.Add(this.panel2);
            this.MenuPanel.Controls.Add(this.mealPanel12);
            this.MenuPanel.Location = new System.Drawing.Point(12, 12);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(808, 426);
            this.MenuPanel.TabIndex = 2;
            // 
            // makeOrder
            // 
            this.makeOrder.Location = new System.Drawing.Point(411, 361);
            this.makeOrder.Name = "makeOrder";
            this.makeOrder.Size = new System.Drawing.Size(87, 23);
            this.makeOrder.TabIndex = 3;
            this.makeOrder.Text = "Add To Order";
            this.makeOrder.UseVisualStyleBackColor = true;
            this.makeOrder.Click += new System.EventHandler(this.MakeOrder_Click);
            // 
            // placeOrder
            // 
            this.placeOrder.Location = new System.Drawing.Point(743, 361);
            this.placeOrder.Name = "placeOrder";
            this.placeOrder.Size = new System.Drawing.Size(55, 55);
            this.placeOrder.TabIndex = 4;
            this.placeOrder.Text = "Place Order";
            this.placeOrder.UseVisualStyleBackColor = true;
            this.placeOrder.Click += new System.EventHandler(this.placeOrder_Click);
            // 
            // orderView
            // 
            this.orderView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.viewName,
            this.viewQty,
            this.viewPrice,
            this.viewTotal});
            this.orderView.HideSelection = false;
            this.orderView.Location = new System.Drawing.Point(410, 3);
            this.orderView.Name = "orderView";
            this.orderView.Size = new System.Drawing.Size(392, 200);
            this.orderView.TabIndex = 5;
            this.orderView.UseCompatibleStateImageBehavior = false;
            this.orderView.View = System.Windows.Forms.View.Details;
            // 
            // viewName
            // 
            this.viewName.Text = "Item Name";
            this.viewName.Width = 200;
            // 
            // viewQty
            // 
            this.viewQty.Text = "Quantity";
            this.viewQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.viewQty.Width = 55;
            // 
            // viewPrice
            // 
            this.viewPrice.Text = "Price";
            this.viewPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // viewTotal
            // 
            this.viewTotal.Text = "Total";
            this.viewTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // subtotal
            // 
            this.subtotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.subtotal.AutoSize = true;
            this.subtotal.Location = new System.Drawing.Point(759, 253);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(0, 13);
            this.subtotal.TabIndex = 10;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(701, 288);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(28, 13);
            this.lblTax.TabIndex = 9;
            this.lblTax.Text = "Tax:";
            // 
            // lblSubTot
            // 
            this.lblSubTot.AutoSize = true;
            this.lblSubTot.Location = new System.Drawing.Point(701, 253);
            this.lblSubTot.Name = "lblSubTot";
            this.lblSubTot.Size = new System.Drawing.Size(49, 13);
            this.lblSubTot.TabIndex = 8;
            this.lblSubTot.Text = "Subtotal:";
            // 
            // tax
            // 
            this.tax.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tax.AutoSize = true;
            this.tax.Location = new System.Drawing.Point(759, 288);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(0, 13);
            this.tax.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(701, 323);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total:";
            // 
            // total
            // 
            this.total.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(759, 323);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 13);
            this.total.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 452);
            this.Controls.Add(this.MenuPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mealPanel12.ResumeLayout(false);
            this.mealPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxQty)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mealPanel12;
        private System.Windows.Forms.Label mealPrice;
        private System.Windows.Forms.Label mealDesc;
        private System.Windows.Forms.Label mealName;
        private System.Windows.Forms.Label lblMenuPrice;
        private System.Windows.Forms.NumericUpDown numBoxQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label qty;
        private System.Windows.Forms.Label lblOrderPrice;
        private System.Windows.Forms.Label lblQty1;
        private System.Windows.Forms.Label orderPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button makeOrder;
        private System.Windows.Forms.Button placeOrder;
        private System.Windows.Forms.ListView orderView;
        private System.Windows.Forms.ColumnHeader viewName;
        private System.Windows.Forms.ColumnHeader viewQty;
        private System.Windows.Forms.ColumnHeader viewPrice;
        private System.Windows.Forms.ColumnHeader viewTotal;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubTot;
        private System.Windows.Forms.Label tax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label total;
    }
}

