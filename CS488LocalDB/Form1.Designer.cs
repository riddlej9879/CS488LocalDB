
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
            this.orderBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.mealPanel = new System.Windows.Forms.Panel();
            this.mealPrice = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.mealDesc = new System.Windows.Forms.Label();
            this.mealName = new System.Windows.Forms.Label();
            this.orderBox.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.mealPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderBox
            // 
            this.orderBox.Controls.Add(this.button1);
            this.orderBox.Location = new System.Drawing.Point(437, 12);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(351, 426);
            this.orderBox.TabIndex = 1;
            this.orderBox.TabStop = false;
            this.orderBox.Text = "Order";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(270, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Place Order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MenuPanel
            // 
            this.MenuPanel.AutoScroll = true;
            this.MenuPanel.AutoScrollMinSize = new System.Drawing.Size(0, 350);
            this.MenuPanel.AutoSize = true;
            this.MenuPanel.Controls.Add(this.mealPanel);
            this.MenuPanel.Location = new System.Drawing.Point(12, 12);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(347, 426);
            this.MenuPanel.TabIndex = 2;
            // 
            // mealPanel
            // 
            this.mealPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mealPanel.Controls.Add(this.mealPrice);
            this.mealPanel.Controls.Add(this.button2);
            this.mealPanel.Controls.Add(this.mealDesc);
            this.mealPanel.Controls.Add(this.mealName);
            this.mealPanel.Location = new System.Drawing.Point(4, 3);
            this.mealPanel.Name = "mealPanel";
            this.mealPanel.Size = new System.Drawing.Size(338, 60);
            this.mealPanel.TabIndex = 1;
            this.mealPanel.Visible = false;
            // 
            // mealPrice
            // 
            this.mealPrice.AutoSize = true;
            this.mealPrice.Location = new System.Drawing.Point(226, 23);
            this.mealPrice.Name = "mealPrice";
            this.mealPrice.Size = new System.Drawing.Size(30, 13);
            this.mealPrice.TabIndex = 3;
            this.mealPrice.Text = "price";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add To Order";
            this.button2.UseVisualStyleBackColor = true;
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
            this.mealName.Location = new System.Drawing.Point(4, 4);
            this.mealName.Name = "mealName";
            this.mealName.Size = new System.Drawing.Size(33, 13);
            this.mealName.TabIndex = 0;
            this.mealName.Text = "name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 921);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.orderBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.orderBox.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.mealPanel.ResumeLayout(false);
            this.mealPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox orderBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel mealPanel;
        private System.Windows.Forms.Label mealPrice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label mealDesc;
        private System.Windows.Forms.Label mealName;
    }
}

