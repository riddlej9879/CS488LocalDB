
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
            this.CreateOrderPanel = new System.Windows.Forms.Panel();
            this.BtnGetAllEmpIDs = new System.Windows.Forms.Button();
            this.BtnGetAllCustIDs = new System.Windows.Forms.Button();
            this.BtnStages = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnGetOrders = new System.Windows.Forms.Button();
            this.BtnGetDetails = new System.Windows.Forms.Button();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrackOrderPanel = new System.Windows.Forms.Panel();
            this.lblTxtDesc = new System.Windows.Forms.Label();
            this.lblTxtStage = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblOrdStage = new System.Windows.Forms.Label();
            this.btnTrackOrder = new System.Windows.Forms.Button();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.lblTrackOrder = new System.Windows.Forms.Label();
            this.orderTrack = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.mealPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxQty)).BeginInit();
            this.CreateOrderPanel.SuspendLayout();
            this.paymentBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.TrackOrderPanel.SuspendLayout();
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
            // CreateOrderPanel
            // 
            this.CreateOrderPanel.AutoScroll = true;
            this.CreateOrderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreateOrderPanel.Controls.Add(this.BtnGetAllEmpIDs);
            this.CreateOrderPanel.Controls.Add(this.BtnGetAllCustIDs);
            this.CreateOrderPanel.Controls.Add(this.BtnStages);
            this.CreateOrderPanel.Controls.Add(this.label2);
            this.CreateOrderPanel.Controls.Add(this.label1);
            this.CreateOrderPanel.Controls.Add(this.button4);
            this.CreateOrderPanel.Controls.Add(this.BtnGetOrders);
            this.CreateOrderPanel.Controls.Add(this.BtnGetDetails);
            this.CreateOrderPanel.Controls.Add(this.paymentBox);
            this.CreateOrderPanel.Controls.Add(this.lblTotal);
            this.CreateOrderPanel.Controls.Add(this.total);
            this.CreateOrderPanel.Controls.Add(this.subtotal);
            this.CreateOrderPanel.Controls.Add(this.lblTax);
            this.CreateOrderPanel.Controls.Add(this.lblSubTot);
            this.CreateOrderPanel.Controls.Add(this.tax);
            this.CreateOrderPanel.Controls.Add(this.orderView);
            this.CreateOrderPanel.Controls.Add(this.placeOrder);
            this.CreateOrderPanel.Controls.Add(this.CreateOrder);
            this.CreateOrderPanel.Controls.Add(this.mealPanel12);
            this.CreateOrderPanel.Location = new System.Drawing.Point(115, 27);
            this.CreateOrderPanel.Name = "CreateOrderPanel";
            this.CreateOrderPanel.Size = new System.Drawing.Size(808, 914);
            this.CreateOrderPanel.TabIndex = 2;
            // 
            // BtnGetAllEmpIDs
            // 
            this.BtnGetAllEmpIDs.Location = new System.Drawing.Point(410, 530);
            this.BtnGetAllEmpIDs.Name = "BtnGetAllEmpIDs";
            this.BtnGetAllEmpIDs.Size = new System.Drawing.Size(100, 25);
            this.BtnGetAllEmpIDs.TabIndex = 21;
            this.BtnGetAllEmpIDs.Text = "Employee IDs";
            this.BtnGetAllEmpIDs.UseVisualStyleBackColor = true;
            this.BtnGetAllEmpIDs.Click += new System.EventHandler(this.BtnGetAllEmpIDs_Click);
            // 
            // BtnGetAllCustIDs
            // 
            this.BtnGetAllCustIDs.Location = new System.Drawing.Point(410, 500);
            this.BtnGetAllCustIDs.Name = "BtnGetAllCustIDs";
            this.BtnGetAllCustIDs.Size = new System.Drawing.Size(100, 25);
            this.BtnGetAllCustIDs.TabIndex = 20;
            this.BtnGetAllCustIDs.Text = "Customer IDs";
            this.BtnGetAllCustIDs.UseVisualStyleBackColor = true;
            this.BtnGetAllCustIDs.Click += new System.EventHandler(this.BtnGetAllCustIDs_Click);
            // 
            // BtnStages
            // 
            this.BtnStages.Location = new System.Drawing.Point(410, 470);
            this.BtnStages.Name = "BtnStages";
            this.BtnStages.Size = new System.Drawing.Size(100, 25);
            this.BtnStages.TabIndex = 19;
            this.BtnStages.Text = "Stages";
            this.BtnStages.UseVisualStyleBackColor = true;
            this.BtnStages.Click += new System.EventHandler(this.BtnGetAllOrderStages_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "MENU";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(410, 380);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 25);
            this.button4.TabIndex = 16;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // BtnGetOrders
            // 
            this.BtnGetOrders.Location = new System.Drawing.Point(410, 440);
            this.BtnGetOrders.Name = "BtnGetOrders";
            this.BtnGetOrders.Size = new System.Drawing.Size(100, 25);
            this.BtnGetOrders.TabIndex = 15;
            this.BtnGetOrders.Text = "Orders";
            this.BtnGetOrders.UseVisualStyleBackColor = true;
            this.BtnGetOrders.Click += new System.EventHandler(this.BtnGetAllOrders_Click);
            // 
            // BtnGetDetails
            // 
            this.BtnGetDetails.Location = new System.Drawing.Point(410, 410);
            this.BtnGetDetails.Name = "BtnGetDetails";
            this.BtnGetDetails.Size = new System.Drawing.Size(100, 25);
            this.BtnGetDetails.TabIndex = 14;
            this.BtnGetDetails.Text = "Order Details";
            this.BtnGetDetails.UseVisualStyleBackColor = true;
            this.BtnGetDetails.Click += new System.EventHandler(this.BtnGetAllDetails_Click);
            // 
            // paymentBox
            // 
            this.paymentBox.Controls.Add(this.radioCheck);
            this.paymentBox.Controls.Add(this.radioCash);
            this.paymentBox.Controls.Add(this.radioCredit);
            this.paymentBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.paymentBox.Location = new System.Drawing.Point(643, 300);
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
            this.lblTotal.Location = new System.Drawing.Point(640, 430);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total:";
            // 
            // total
            // 
            this.total.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.total.Location = new System.Drawing.Point(720, 430);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(75, 13);
            this.total.TabIndex = 11;
            this.total.Text = "$1,000,000.00";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subtotal
            // 
            this.subtotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.subtotal.Location = new System.Drawing.Point(720, 390);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(75, 13);
            this.subtotal.TabIndex = 10;
            this.subtotal.Text = "$1,000,000.00";
            this.subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(640, 410);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(28, 13);
            this.lblTax.TabIndex = 9;
            this.lblTax.Text = "Tax:";
            // 
            // lblSubTot
            // 
            this.lblSubTot.AutoSize = true;
            this.lblSubTot.Location = new System.Drawing.Point(640, 390);
            this.lblSubTot.Name = "lblSubTot";
            this.lblSubTot.Size = new System.Drawing.Size(49, 13);
            this.lblSubTot.TabIndex = 8;
            this.lblSubTot.Text = "Subtotal:";
            // 
            // tax
            // 
            this.tax.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tax.Location = new System.Drawing.Point(720, 410);
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
            this.orderView.Size = new System.Drawing.Size(392, 271);
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
            this.placeOrder.Location = new System.Drawing.Point(747, 310);
            this.placeOrder.Name = "placeOrder";
            this.placeOrder.Size = new System.Drawing.Size(55, 55);
            this.placeOrder.TabIndex = 4;
            this.placeOrder.Text = "Place Order";
            this.placeOrder.UseVisualStyleBackColor = true;
            this.placeOrder.Click += new System.EventHandler(this.PlaceOrder_Click);
            // 
            // CreateOrder
            // 
            this.CreateOrder.Location = new System.Drawing.Point(410, 300);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(100, 25);
            this.CreateOrder.TabIndex = 3;
            this.CreateOrder.Text = "Add To Order";
            this.CreateOrder.UseVisualStyleBackColor = true;
            this.CreateOrder.Click += new System.EventHandler(this.CreateOrder_Click);
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
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeOrderToolStripMenuItem,
            this.trackOrderToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.CustomerToolStripMenuItem_Click);
            // 
            // placeOrderToolStripMenuItem
            // 
            this.placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
            this.placeOrderToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.placeOrderToolStripMenuItem.Text = "Place Order";
            this.placeOrderToolStripMenuItem.Click += new System.EventHandler(this.PlaceOrderToolStripMenuItem_Click);
            // 
            // trackOrderToolStripMenuItem
            // 
            this.trackOrderToolStripMenuItem.Name = "trackOrderToolStripMenuItem";
            this.trackOrderToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.trackOrderToolStripMenuItem.Text = "Track Order";
            this.trackOrderToolStripMenuItem.Click += new System.EventHandler(this.TrackOrderToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.EmployeeToolStripMenuItem_Click);
            // 
            // TrackOrderPanel
            // 
            this.TrackOrderPanel.Controls.Add(this.lblTxtDesc);
            this.TrackOrderPanel.Controls.Add(this.lblTxtStage);
            this.TrackOrderPanel.Controls.Add(this.lblDesc);
            this.TrackOrderPanel.Controls.Add(this.lblOrdStage);
            this.TrackOrderPanel.Controls.Add(this.btnTrackOrder);
            this.TrackOrderPanel.Controls.Add(this.txtOrder);
            this.TrackOrderPanel.Controls.Add(this.lblTrackOrder);
            this.TrackOrderPanel.Controls.Add(this.orderTrack);
            this.TrackOrderPanel.Controls.Add(this.label3);
            this.TrackOrderPanel.Location = new System.Drawing.Point(10, 222);
            this.TrackOrderPanel.Name = "TrackOrderPanel";
            this.TrackOrderPanel.Size = new System.Drawing.Size(808, 914);
            this.TrackOrderPanel.TabIndex = 20;
            // 
            // lblTxtDesc
            // 
            this.lblTxtDesc.AutoSize = true;
            this.lblTxtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtDesc.Location = new System.Drawing.Point(110, 200);
            this.lblTxtDesc.Name = "lblTxtDesc";
            this.lblTxtDesc.Size = new System.Drawing.Size(18, 17);
            this.lblTxtDesc.TabIndex = 13;
            this.lblTxtDesc.Text = "--";
            // 
            // lblTxtStage
            // 
            this.lblTxtStage.AutoSize = true;
            this.lblTxtStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtStage.Location = new System.Drawing.Point(110, 170);
            this.lblTxtStage.Name = "lblTxtStage";
            this.lblTxtStage.Size = new System.Drawing.Size(18, 17);
            this.lblTxtStage.TabIndex = 12;
            this.lblTxtStage.Text = "--";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(4, 200);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(83, 17);
            this.lblDesc.TabIndex = 11;
            this.lblDesc.Text = "Description:";
            // 
            // lblOrdStage
            // 
            this.lblOrdStage.AutoSize = true;
            this.lblOrdStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdStage.Location = new System.Drawing.Point(4, 170);
            this.lblOrdStage.Name = "lblOrdStage";
            this.lblOrdStage.Size = new System.Drawing.Size(93, 17);
            this.lblOrdStage.TabIndex = 10;
            this.lblOrdStage.Text = "Order Status:";
            // 
            // btnTrackOrder
            // 
            this.btnTrackOrder.Location = new System.Drawing.Point(65, 50);
            this.btnTrackOrder.Name = "btnTrackOrder";
            this.btnTrackOrder.Size = new System.Drawing.Size(75, 23);
            this.btnTrackOrder.TabIndex = 9;
            this.btnTrackOrder.Text = "Track";
            this.btnTrackOrder.UseVisualStyleBackColor = true;
            this.btnTrackOrder.Click += new System.EventHandler(this.BtnTrackOrder_Click);
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(65, 25);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(75, 20);
            this.txtOrder.TabIndex = 8;
            this.txtOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTrackOrder
            // 
            this.lblTrackOrder.AutoSize = true;
            this.lblTrackOrder.Location = new System.Drawing.Point(413, 5);
            this.lblTrackOrder.Name = "lblTrackOrder";
            this.lblTrackOrder.Size = new System.Drawing.Size(100, 13);
            this.lblTrackOrder.TabIndex = 7;
            this.lblTrackOrder.Text = "TRACKED ORDER";
            // 
            // orderTrack
            // 
            this.orderTrack.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.orderTrack.HideSelection = false;
            this.orderTrack.Location = new System.Drawing.Point(410, 23);
            this.orderTrack.Name = "orderTrack";
            this.orderTrack.Size = new System.Drawing.Size(392, 200);
            this.orderTrack.TabIndex = 6;
            this.orderTrack.UseCompatibleStateImageBehavior = false;
            this.orderTrack.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 55;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ENTER ORDER NUMBER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 953);
            this.Controls.Add(this.TrackOrderPanel);
            this.Controls.Add(this.CreateOrderPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mealPanel12.ResumeLayout(false);
            this.mealPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxQty)).EndInit();
            this.CreateOrderPanel.ResumeLayout(false);
            this.CreateOrderPanel.PerformLayout();
            this.paymentBox.ResumeLayout(false);
            this.paymentBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TrackOrderPanel.ResumeLayout(false);
            this.TrackOrderPanel.PerformLayout();
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
        private System.Windows.Forms.Panel CreateOrderPanel;
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
        private System.Windows.Forms.Button BtnGetDetails;
        private System.Windows.Forms.Button BtnGetOrders;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackOrderToolStripMenuItem;
        private System.Windows.Forms.Panel TrackOrderPanel;
        private System.Windows.Forms.Label lblTrackOrder;
        private System.Windows.Forms.ListView orderTrack;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Button btnTrackOrder;
        private System.Windows.Forms.Label lblTxtDesc;
        private System.Windows.Forms.Label lblTxtStage;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblOrdStage;
        private System.Windows.Forms.Button BtnStages;
        private System.Windows.Forms.Button BtnGetAllCustIDs;
        private System.Windows.Forms.Button BtnGetAllEmpIDs;
    }
}

