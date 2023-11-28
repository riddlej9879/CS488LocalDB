
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.paymentBox = new System.Windows.Forms.GroupBox();
            this.radioCheck = new System.Windows.Forms.RadioButton();
            this.radioCash = new System.Windows.Forms.RadioButton();
            this.radioCredit = new System.Windows.Forms.RadioButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.subtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubTot = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.Label();
            this.orderView = new System.Windows.Forms.ListView();
            this.viewName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.placeOrder = new System.Windows.Forms.Button();
            this.CreateOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mealPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxQty)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.paymentBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.mealPanel12.Location = new System.Drawing.Point(4, 23);
            this.mealPanel12.Name = "mealPanel12";
            this.mealPanel12.Size = new System.Drawing.Size(400, 60);
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
            // MenuPanel
            // 
            this.MenuPanel.AutoScroll = true;
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel.Controls.Add(this.label2);
            this.MenuPanel.Controls.Add(this.label1);
            this.MenuPanel.Controls.Add(this.button4);
            this.MenuPanel.Controls.Add(this.button3);
            this.MenuPanel.Controls.Add(this.button1);
            this.MenuPanel.Controls.Add(this.paymentBox);
            this.MenuPanel.Controls.Add(this.lblTotal);
            this.MenuPanel.Controls.Add(this.total);
            this.MenuPanel.Controls.Add(this.subtotal);
            this.MenuPanel.Controls.Add(this.lblTax);
            this.MenuPanel.Controls.Add(this.lblSubTot);
            this.MenuPanel.Controls.Add(this.tax);
            this.MenuPanel.Controls.Add(this.orderView);
            this.MenuPanel.Controls.Add(this.placeOrder);
            this.MenuPanel.Controls.Add(this.CreateOrder);
            this.MenuPanel.Controls.Add(this.mealPanel12);
            this.MenuPanel.Location = new System.Drawing.Point(12, 27);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(808, 914);
            this.MenuPanel.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(410, 305);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 25);
            this.button4.TabIndex = 16;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.DeleteOrders);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(410, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 25);
            this.button3.TabIndex = 15;
            this.button3.Text = "Orders";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 14;
            this.button1.Text = "Order Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // paymentBox
            // 
            this.paymentBox.Controls.Add(this.radioCheck);
            this.paymentBox.Controls.Add(this.radioCash);
            this.paymentBox.Controls.Add(this.radioCredit);
            this.paymentBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.paymentBox.Location = new System.Drawing.Point(643, 230);
            this.paymentBox.Name = "paymentBox";
            this.paymentBox.Size = new System.Drawing.Size(90, 75);
            this.paymentBox.TabIndex = 13;
            this.paymentBox.TabStop = false;
            this.paymentBox.Text = "Payment Type";
            // 
            // radioCheck
            // 
            this.radioCheck.AutoSize = true;
            this.radioCheck.Location = new System.Drawing.Point(10, 55);
            this.radioCheck.Name = "radioCheck";
            this.radioCheck.Size = new System.Drawing.Size(56, 17);
            this.radioCheck.TabIndex = 2;
            this.radioCheck.TabStop = true;
            this.radioCheck.Text = "Check";
            this.radioCheck.UseVisualStyleBackColor = true;
            // 
            // radioCash
            // 
            this.radioCash.AutoSize = true;
            this.radioCash.Location = new System.Drawing.Point(10, 35);
            this.radioCash.Name = "radioCash";
            this.radioCash.Size = new System.Drawing.Size(49, 17);
            this.radioCash.TabIndex = 1;
            this.radioCash.TabStop = true;
            this.radioCash.Text = "Cash";
            this.radioCash.UseVisualStyleBackColor = true;
            // 
            // radioCredit
            // 
            this.radioCredit.AutoSize = true;
            this.radioCredit.Location = new System.Drawing.Point(10, 15);
            this.radioCredit.Name = "radioCredit";
            this.radioCredit.Size = new System.Drawing.Size(52, 17);
            this.radioCredit.TabIndex = 0;
            this.radioCredit.TabStop = true;
            this.radioCredit.Text = "Credit";
            this.radioCredit.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(640, 360);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total:";
            // 
            // total
            // 
            this.total.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.total.Location = new System.Drawing.Point(720, 360);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(75, 13);
            this.total.TabIndex = 11;
            this.total.Text = "$1,000,000.00";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subtotal
            // 
            this.subtotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.subtotal.Location = new System.Drawing.Point(720, 320);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(75, 13);
            this.subtotal.TabIndex = 10;
            this.subtotal.Text = "$1,000,000.00";
            this.subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(640, 340);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(28, 13);
            this.lblTax.TabIndex = 9;
            this.lblTax.Text = "Tax:";
            // 
            // lblSubTot
            // 
            this.lblSubTot.AutoSize = true;
            this.lblSubTot.Location = new System.Drawing.Point(640, 320);
            this.lblSubTot.Name = "lblSubTot";
            this.lblSubTot.Size = new System.Drawing.Size(49, 13);
            this.lblSubTot.TabIndex = 8;
            this.lblSubTot.Text = "Subtotal:";
            // 
            // tax
            // 
            this.tax.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tax.Location = new System.Drawing.Point(720, 340);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(75, 13);
            this.tax.TabIndex = 7;
            this.tax.Text = "$1,000,000.00";
            this.tax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderView
            // 
            this.orderView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.viewName,
            this.viewQty,
            this.viewPrice,
            this.viewTotal});
            this.orderView.HideSelection = false;
            this.orderView.Location = new System.Drawing.Point(410, 23);
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
            // placeOrder
            // 
            this.placeOrder.Location = new System.Drawing.Point(747, 240);
            this.placeOrder.Name = "placeOrder";
            this.placeOrder.Size = new System.Drawing.Size(55, 55);
            this.placeOrder.TabIndex = 4;
            this.placeOrder.Text = "Place Order";
            this.placeOrder.UseVisualStyleBackColor = true;
            this.placeOrder.Click += new System.EventHandler(this.PlaceOrder_Click);
            // 
            // CreateOrder
            // 
            this.CreateOrder.Location = new System.Drawing.Point(410, 230);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(100, 25);
            this.CreateOrder.TabIndex = 3;
            this.CreateOrder.Text = "Add To Order";
            this.CreateOrder.UseVisualStyleBackColor = true;
            this.CreateOrder.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "MENU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "ORDER";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.CustomerToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.EmployeeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 953);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mealPanel12.ResumeLayout(false);
            this.mealPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxQty)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.paymentBox.ResumeLayout(false);
            this.paymentBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button CreateOrder;
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
        private System.Windows.Forms.GroupBox paymentBox;
        private System.Windows.Forms.RadioButton radioCheck;
        private System.Windows.Forms.RadioButton radioCash;
        private System.Windows.Forms.RadioButton radioCredit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
    }
}

