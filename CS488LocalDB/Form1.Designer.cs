
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
            this.CreateOrderPanel = new System.Windows.Forms.Panel();
            this.TrackOrderPanel = new System.Windows.Forms.Panel();
            this.lblTxtTrackTot = new System.Windows.Forms.Label();
            this.lblTrackTot = new System.Windows.Forms.Label();
            this.lblTxtDesc = new System.Windows.Forms.Label();
            this.lblTxtStage = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblOrdStage = new System.Windows.Forms.Label();
            this.btnTrackOrder = new System.Windows.Forms.Button();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.lblTrackOrder = new System.Windows.Forms.Label();
            this.trackView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
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
            this.mealPanel12 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.numBoxQty = new System.Windows.Forms.NumericUpDown();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblMenuPrice = new System.Windows.Forms.Label();
            this.mealPrice = new System.Windows.Forms.Label();
            this.mealDesc = new System.Windows.Forms.Label();
            this.mealName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateOrderPanel.SuspendLayout();
            this.TrackOrderPanel.SuspendLayout();
            this.paymentBox.SuspendLayout();
            this.mealPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxQty)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateOrderPanel
            // 
            this.CreateOrderPanel.AutoScroll = true;
            this.CreateOrderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreateOrderPanel.Controls.Add(this.TrackOrderPanel);
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
            this.CreateOrderPanel.Location = new System.Drawing.Point(0, 52);
            this.CreateOrderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.CreateOrderPanel.Name = "CreateOrderPanel";
            this.CreateOrderPanel.Size = new System.Drawing.Size(1109, 1027);
            this.CreateOrderPanel.TabIndex = 2;
            // 
            // TrackOrderPanel
            // 
            this.TrackOrderPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TrackOrderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TrackOrderPanel.Controls.Add(this.trackView);
            this.TrackOrderPanel.Controls.Add(this.lblTxtTrackTot);
            this.TrackOrderPanel.Controls.Add(this.lblTrackTot);
            this.TrackOrderPanel.Controls.Add(this.lblTxtDesc);
            this.TrackOrderPanel.Controls.Add(this.lblTxtStage);
            this.TrackOrderPanel.Controls.Add(this.lblDesc);
            this.TrackOrderPanel.Controls.Add(this.lblOrdStage);
            this.TrackOrderPanel.Controls.Add(this.btnTrackOrder);
            this.TrackOrderPanel.Controls.Add(this.txtOrder);
            this.TrackOrderPanel.Controls.Add(this.lblTrackOrder);
            this.TrackOrderPanel.Controls.Add(this.label3);
            this.TrackOrderPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TrackOrderPanel.ForeColor = System.Drawing.Color.White;
            this.TrackOrderPanel.Location = new System.Drawing.Point(80, 6);
            this.TrackOrderPanel.Name = "TrackOrderPanel";
            this.TrackOrderPanel.Size = new System.Drawing.Size(771, 927);
            this.TrackOrderPanel.TabIndex = 20;
            // 
            // lblTxtTrackTot
            // 
            this.lblTxtTrackTot.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTxtTrackTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtTrackTot.ForeColor = System.Drawing.Color.Black;
            this.lblTxtTrackTot.Location = new System.Drawing.Point(-182, 241);
            this.lblTxtTrackTot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTxtTrackTot.Name = "lblTxtTrackTot";
            this.lblTxtTrackTot.Size = new System.Drawing.Size(140, 25);
            this.lblTxtTrackTot.TabIndex = 15;
            this.lblTxtTrackTot.Text = "$1,000,000.00";
            this.lblTxtTrackTot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTxtTrackTot.Click += new System.EventHandler(this.lblTxtTrackTot_Click);
            // 
            // lblTrackTot
            // 
            this.lblTrackTot.AutoSize = true;
            this.lblTrackTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackTot.ForeColor = System.Drawing.Color.Black;
            this.lblTrackTot.Location = new System.Drawing.Point(12, 290);
            this.lblTrackTot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrackTot.Name = "lblTrackTot";
            this.lblTrackTot.Size = new System.Drawing.Size(51, 20);
            this.lblTrackTot.TabIndex = 14;
            this.lblTrackTot.Text = "Total:";
            this.lblTrackTot.Click += new System.EventHandler(this.lblTrackTot_Click);
            // 
            // lblTxtDesc
            // 
            this.lblTxtDesc.AutoSize = true;
            this.lblTxtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtDesc.ForeColor = System.Drawing.Color.Black;
            this.lblTxtDesc.Location = new System.Drawing.Point(154, 253);
            this.lblTxtDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTxtDesc.Name = "lblTxtDesc";
            this.lblTxtDesc.Size = new System.Drawing.Size(21, 20);
            this.lblTxtDesc.TabIndex = 13;
            this.lblTxtDesc.Text = "--";
            this.lblTxtDesc.Click += new System.EventHandler(this.lblTxtDesc_Click);
            // 
            // lblTxtStage
            // 
            this.lblTxtStage.AutoSize = true;
            this.lblTxtStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtStage.ForeColor = System.Drawing.Color.Black;
            this.lblTxtStage.Location = new System.Drawing.Point(154, 216);
            this.lblTxtStage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTxtStage.Name = "lblTxtStage";
            this.lblTxtStage.Size = new System.Drawing.Size(21, 20);
            this.lblTxtStage.TabIndex = 12;
            this.lblTxtStage.Text = "--";
            this.lblTxtStage.Click += new System.EventHandler(this.lblTxtStage_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.Black;
            this.lblDesc.Location = new System.Drawing.Point(12, 253);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(100, 20);
            this.lblDesc.TabIndex = 11;
            this.lblDesc.Text = "Description:";
            this.lblDesc.Click += new System.EventHandler(this.lblDesc_Click);
            // 
            // lblOrdStage
            // 
            this.lblOrdStage.AutoSize = true;
            this.lblOrdStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdStage.ForeColor = System.Drawing.Color.Black;
            this.lblOrdStage.Location = new System.Drawing.Point(12, 216);
            this.lblOrdStage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrdStage.Name = "lblOrdStage";
            this.lblOrdStage.Size = new System.Drawing.Size(110, 20);
            this.lblOrdStage.TabIndex = 10;
            this.lblOrdStage.Text = "Order Status:";
            this.lblOrdStage.Click += new System.EventHandler(this.lblOrdStage_Click);
            // 
            // btnTrackOrder
            // 
            this.btnTrackOrder.BackColor = System.Drawing.SystemColors.Control;
            this.btnTrackOrder.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnTrackOrder.Location = new System.Drawing.Point(94, 69);
            this.btnTrackOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrackOrder.Name = "btnTrackOrder";
            this.btnTrackOrder.Size = new System.Drawing.Size(100, 28);
            this.btnTrackOrder.TabIndex = 9;
            this.btnTrackOrder.Text = "Track";
            this.btnTrackOrder.UseVisualStyleBackColor = false;
            this.btnTrackOrder.Click += new System.EventHandler(this.BtnTrackOrder_Click);
            // 
            // txtOrder
            // 
            this.txtOrder.BackColor = System.Drawing.SystemColors.Window;
            this.txtOrder.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOrder.Location = new System.Drawing.Point(94, 38);
            this.txtOrder.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(99, 22);
            this.txtOrder.TabIndex = 8;
            this.txtOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOrder.TextChanged += new System.EventHandler(this.txtOrder_TextChanged);
            // 
            // lblTrackOrder
            // 
            this.lblTrackOrder.AutoSize = true;
            this.lblTrackOrder.ForeColor = System.Drawing.Color.Black;
            this.lblTrackOrder.Location = new System.Drawing.Point(558, 13);
            this.lblTrackOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrackOrder.Name = "lblTrackOrder";
            this.lblTrackOrder.Size = new System.Drawing.Size(123, 16);
            this.lblTrackOrder.TabIndex = 7;
            this.lblTrackOrder.Text = "TRACKED ORDER";
            this.lblTrackOrder.Click += new System.EventHandler(this.lblTrackOrder_Click);
            // 
            // trackView
            // 
            this.trackView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trackView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.trackView.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.trackView.HideSelection = false;
            this.trackView.Location = new System.Drawing.Point(554, 35);
            this.trackView.Margin = new System.Windows.Forms.Padding(4);
            this.trackView.Name = "trackView";
            this.trackView.Size = new System.Drawing.Size(521, 245);
            this.trackView.TabIndex = 6;
            this.trackView.UseCompatibleStateImageBehavior = false;
            this.trackView.View = System.Windows.Forms.View.Details;
            this.trackView.SelectedIndexChanged += new System.EventHandler(this.trackView_SelectedIndexChanged);
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
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "ENTER ORDER NUMBER";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BtnGetAllEmpIDs
            // 
            this.BtnGetAllEmpIDs.Location = new System.Drawing.Point(547, 652);
            this.BtnGetAllEmpIDs.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGetAllEmpIDs.Name = "BtnGetAllEmpIDs";
            this.BtnGetAllEmpIDs.Size = new System.Drawing.Size(133, 31);
            this.BtnGetAllEmpIDs.TabIndex = 21;
            this.BtnGetAllEmpIDs.Text = "Employee IDs";
            this.BtnGetAllEmpIDs.UseVisualStyleBackColor = true;
            this.BtnGetAllEmpIDs.Click += new System.EventHandler(this.BtnGetAllEmpIDs_Click);
            // 
            // BtnGetAllCustIDs
            // 
            this.BtnGetAllCustIDs.Location = new System.Drawing.Point(547, 615);
            this.BtnGetAllCustIDs.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGetAllCustIDs.Name = "BtnGetAllCustIDs";
            this.BtnGetAllCustIDs.Size = new System.Drawing.Size(133, 31);
            this.BtnGetAllCustIDs.TabIndex = 20;
            this.BtnGetAllCustIDs.Text = "Customer IDs";
            this.BtnGetAllCustIDs.UseVisualStyleBackColor = true;
            this.BtnGetAllCustIDs.Click += new System.EventHandler(this.BtnGetAllCustIDs_Click);
            // 
            // BtnStages
            // 
            this.BtnStages.Location = new System.Drawing.Point(547, 578);
            this.BtnStages.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStages.Name = "BtnStages";
            this.BtnStages.Size = new System.Drawing.Size(133, 31);
            this.BtnStages.TabIndex = 19;
            this.BtnStages.Text = "Stages";
            this.BtnStages.UseVisualStyleBackColor = true;
            this.BtnStages.Click += new System.EventHandler(this.BtnGetAllOrderStages_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "ORDER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "MENU";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(547, 468);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 31);
            this.button4.TabIndex = 16;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // BtnGetOrders
            // 
            this.BtnGetOrders.Location = new System.Drawing.Point(547, 542);
            this.BtnGetOrders.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGetOrders.Name = "BtnGetOrders";
            this.BtnGetOrders.Size = new System.Drawing.Size(133, 31);
            this.BtnGetOrders.TabIndex = 15;
            this.BtnGetOrders.Text = "Orders";
            this.BtnGetOrders.UseVisualStyleBackColor = true;
            this.BtnGetOrders.Click += new System.EventHandler(this.BtnGetAllOrders_Click);
            // 
            // BtnGetDetails
            // 
            this.BtnGetDetails.Location = new System.Drawing.Point(547, 505);
            this.BtnGetDetails.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGetDetails.Name = "BtnGetDetails";
            this.BtnGetDetails.Size = new System.Drawing.Size(133, 31);
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
            this.paymentBox.Location = new System.Drawing.Point(828, 327);
            this.paymentBox.Margin = new System.Windows.Forms.Padding(4);
            this.paymentBox.Name = "paymentBox";
            this.paymentBox.Padding = new System.Windows.Forms.Padding(4);
            this.paymentBox.Size = new System.Drawing.Size(120, 92);
            this.paymentBox.TabIndex = 13;
            this.paymentBox.TabStop = false;
            this.paymentBox.Text = "Payment Type";
            // 
            // radioCheck
            // 
            this.radioCheck.AutoSize = true;
            this.radioCheck.Location = new System.Drawing.Point(13, 68);
            this.radioCheck.Margin = new System.Windows.Forms.Padding(4);
            this.radioCheck.Name = "radioCheck";
            this.radioCheck.Size = new System.Drawing.Size(66, 20);
            this.radioCheck.TabIndex = 2;
            this.radioCheck.TabStop = true;
            this.radioCheck.Text = "Check";
            this.radioCheck.UseVisualStyleBackColor = true;
            // 
            // radioCash
            // 
            this.radioCash.AutoSize = true;
            this.radioCash.Location = new System.Drawing.Point(13, 43);
            this.radioCash.Margin = new System.Windows.Forms.Padding(4);
            this.radioCash.Name = "radioCash";
            this.radioCash.Size = new System.Drawing.Size(59, 20);
            this.radioCash.TabIndex = 1;
            this.radioCash.TabStop = true;
            this.radioCash.Text = "Cash";
            this.radioCash.UseVisualStyleBackColor = true;
            // 
            // radioCredit
            // 
            this.radioCredit.AutoSize = true;
            this.radioCredit.Location = new System.Drawing.Point(13, 18);
            this.radioCredit.Margin = new System.Windows.Forms.Padding(4);
            this.radioCredit.Name = "radioCredit";
            this.radioCredit.Size = new System.Drawing.Size(63, 20);
            this.radioCredit.TabIndex = 0;
            this.radioCredit.TabStop = true;
            this.radioCredit.Text = "Credit";
            this.radioCredit.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(873, 487);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 16);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(940, 487);
            this.total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(86, 16);
            this.total.TabIndex = 11;
            this.total.Text = "$1,000,000.00";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Location = new System.Drawing.Point(940, 438);
            this.subtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(86, 16);
            this.subtotal.TabIndex = 10;
            this.subtotal.Text = "$1,000,000.00";
            this.subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(873, 463);
            this.lblTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(33, 16);
            this.lblTax.TabIndex = 9;
            this.lblTax.Text = "Tax:";
            // 
            // lblSubTot
            // 
            this.lblSubTot.AutoSize = true;
            this.lblSubTot.Location = new System.Drawing.Point(873, 438);
            this.lblSubTot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTot.Name = "lblSubTot";
            this.lblSubTot.Size = new System.Drawing.Size(59, 16);
            this.lblSubTot.TabIndex = 8;
            this.lblSubTot.Text = "Subtotal:";
            // 
            // tax
            // 
            this.tax.AutoSize = true;
            this.tax.Location = new System.Drawing.Point(940, 463);
            this.tax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(86, 16);
            this.tax.TabIndex = 7;
            this.tax.Text = "$1,000,000.00";
            this.tax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderView
            // 
            this.orderView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.viewName,
            this.viewQty,
            this.viewPrice,
            this.viewTotal});
            this.orderView.ForeColor = System.Drawing.Color.Black;
            this.orderView.HideSelection = false;
            this.orderView.Location = new System.Drawing.Point(547, 28);
            this.orderView.Margin = new System.Windows.Forms.Padding(4);
            this.orderView.Name = "orderView";
            this.orderView.Size = new System.Drawing.Size(521, 285);
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
            this.placeOrder.Location = new System.Drawing.Point(967, 340);
            this.placeOrder.Margin = new System.Windows.Forms.Padding(4);
            this.placeOrder.Name = "placeOrder";
            this.placeOrder.Size = new System.Drawing.Size(73, 68);
            this.placeOrder.TabIndex = 4;
            this.placeOrder.Text = "Place Order";
            this.placeOrder.UseVisualStyleBackColor = true;
            this.placeOrder.Click += new System.EventHandler(this.PlaceOrder_Click);
            // 
            // CreateOrder
            // 
            this.CreateOrder.Location = new System.Drawing.Point(547, 369);
            this.CreateOrder.Margin = new System.Windows.Forms.Padding(4);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(133, 31);
            this.CreateOrder.TabIndex = 3;
            this.CreateOrder.Text = "Add To Order";
            this.CreateOrder.UseVisualStyleBackColor = true;
            this.CreateOrder.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // mealPanel12
            // 
            this.mealPanel12.AutoScroll = true;
            this.mealPanel12.BackColor = System.Drawing.Color.Gainsboro;
            this.mealPanel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mealPanel12.Controls.Add(this.button2);
            this.mealPanel12.Controls.Add(this.numBoxQty);
            this.mealPanel12.Controls.Add(this.lblQty);
            this.mealPanel12.Controls.Add(this.lblMenuPrice);
            this.mealPanel12.Controls.Add(this.mealPrice);
            this.mealPanel12.Controls.Add(this.mealDesc);
            this.mealPanel12.Controls.Add(this.mealName);
            this.mealPanel12.Location = new System.Drawing.Point(5, 28);
            this.mealPanel12.Margin = new System.Windows.Forms.Padding(4);
            this.mealPanel12.Name = "mealPanel12";
            this.mealPanel12.Size = new System.Drawing.Size(533, 73);
            this.mealPanel12.TabIndex = 1;
            this.mealPanel12.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(457, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 64);
            this.button2.TabIndex = 8;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // numBoxQty
            // 
            this.numBoxQty.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.numBoxQty.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numBoxQty.Location = new System.Drawing.Point(347, 4);
            this.numBoxQty.Margin = new System.Windows.Forms.Padding(4);
            this.numBoxQty.Name = "numBoxQty";
            this.numBoxQty.Size = new System.Drawing.Size(53, 22);
            this.numBoxQty.TabIndex = 7;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(267, 6);
            this.lblQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(58, 16);
            this.lblQty.TabIndex = 6;
            this.lblQty.Text = "Quantity:";
            // 
            // lblMenuPrice
            // 
            this.lblMenuPrice.AutoSize = true;
            this.lblMenuPrice.Location = new System.Drawing.Point(267, 49);
            this.lblMenuPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenuPrice.Name = "lblMenuPrice";
            this.lblMenuPrice.Size = new System.Drawing.Size(41, 16);
            this.lblMenuPrice.TabIndex = 5;
            this.lblMenuPrice.Text = "Price:";
            // 
            // mealPrice
            // 
            this.mealPrice.AutoSize = true;
            this.mealPrice.Location = new System.Drawing.Point(360, 49);
            this.mealPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mealPrice.Name = "mealPrice";
            this.mealPrice.Size = new System.Drawing.Size(37, 16);
            this.mealPrice.TabIndex = 3;
            this.mealPrice.Text = "price";
            // 
            // mealDesc
            // 
            this.mealDesc.AutoSize = true;
            this.mealDesc.Location = new System.Drawing.Point(5, 34);
            this.mealDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mealDesc.Name = "mealDesc";
            this.mealDesc.Size = new System.Drawing.Size(37, 16);
            this.mealDesc.TabIndex = 1;
            this.mealDesc.Text = "desc";
            // 
            // mealName
            // 
            this.mealName.AutoSize = true;
            this.mealName.Location = new System.Drawing.Point(5, 6);
            this.mealName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mealName.Name = "mealName";
            this.mealName.Size = new System.Drawing.Size(41, 16);
            this.mealName.TabIndex = 0;
            this.mealName.Text = "name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1109, 30);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeOrderToolStripMenuItem,
            this.trackOrderToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.CustomerToolStripMenuItem_Click);
            // 
            // placeOrderToolStripMenuItem
            // 
            this.placeOrderToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
            this.placeOrderToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.placeOrderToolStripMenuItem.Text = "Place Order";
            this.placeOrderToolStripMenuItem.Click += new System.EventHandler(this.PlaceOrderToolStripMenuItem_Click);
            // 
            // trackOrderToolStripMenuItem
            // 
            this.trackOrderToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.trackOrderToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.trackOrderToolStripMenuItem.Name = "trackOrderToolStripMenuItem";
            this.trackOrderToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.trackOrderToolStripMenuItem.Text = "Track Order";
            this.trackOrderToolStripMenuItem.Click += new System.EventHandler(this.TrackOrderToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.EmployeeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1109, 1055);
            this.Controls.Add(this.CreateOrderPanel);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CreateOrderPanel.ResumeLayout(false);
            this.CreateOrderPanel.PerformLayout();
            this.TrackOrderPanel.ResumeLayout(false);
            this.TrackOrderPanel.PerformLayout();
            this.paymentBox.ResumeLayout(false);
            this.paymentBox.PerformLayout();
            this.mealPanel12.ResumeLayout(false);
            this.mealPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxQty)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label lblTrackOrder;
        private System.Windows.Forms.ListView trackView;
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
        private System.Windows.Forms.Label lblTxtTrackTot;
        private System.Windows.Forms.Label lblTrackTot;
        private System.Windows.Forms.Panel mealPanel12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numBoxQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblMenuPrice;
        private System.Windows.Forms.Label mealPrice;
        private System.Windows.Forms.Label mealDesc;
        private System.Windows.Forms.Label mealName;
        private System.Windows.Forms.Panel TrackOrderPanel;
    }
}

