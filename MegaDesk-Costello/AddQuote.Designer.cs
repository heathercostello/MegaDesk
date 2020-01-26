namespace MegaDesk_Costello
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DepthTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.DrawersLabel = new System.Windows.Forms.Label();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.DrawerDropDown = new System.Windows.Forms.ComboBox();
            this.MaterialTypeDropDown = new System.Windows.Forms.ComboBox();
            this.OrderTimeLabel = new System.Windows.Forms.Label();
            this.OrderProcessingDropdown = new System.Windows.Forms.ComboBox();
            this.SubmitOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(104, 229);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(183, 31);
            this.WidthTextBox.TabIndex = 0;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            this.WidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.WidthTextBox_Validating);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(104, 100);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(180, 31);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // DepthTextBox
            // 
            this.DepthTextBox.Location = new System.Drawing.Point(104, 322);
            this.DepthTextBox.Name = "DepthTextBox";
            this.DepthTextBox.Size = new System.Drawing.Size(183, 31);
            this.DepthTextBox.TabIndex = 2;
            this.DepthTextBox.TextChanged += new System.EventHandler(this.DepthTextBox_TextChanged);
            this.DepthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DepthTextBox_Validating);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(99, 44);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(249, 25);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Please Enter Your Name";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(99, 168);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(150, 25);
            this.WidthLabel.TabIndex = 4;
            this.WidthLabel.Text = "Width Of Desk";
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Location = new System.Drawing.Point(99, 282);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(152, 25);
            this.DepthLabel.TabIndex = 5;
            this.DepthLabel.Text = "Depth Of Desk";
            // 
            // DrawersLabel
            // 
            this.DrawersLabel.AutoSize = true;
            this.DrawersLabel.Location = new System.Drawing.Point(99, 381);
            this.DrawersLabel.Name = "DrawersLabel";
            this.DrawersLabel.Size = new System.Drawing.Size(200, 25);
            this.DrawersLabel.TabIndex = 6;
            this.DrawersLabel.Text = "Number Of Drawers";
            this.DrawersLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Location = new System.Drawing.Point(99, 483);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(143, 25);
            this.MaterialLabel.TabIndex = 7;
            this.MaterialLabel.Text = "Material Type";
            // 
            // DrawerDropDown
            // 
            this.DrawerDropDown.FormattingEnabled = true;
            this.DrawerDropDown.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.DrawerDropDown.Location = new System.Drawing.Point(104, 421);
            this.DrawerDropDown.Name = "DrawerDropDown";
            this.DrawerDropDown.Size = new System.Drawing.Size(183, 33);
            this.DrawerDropDown.TabIndex = 8;
            // 
            // MaterialTypeDropDown
            // 
            this.MaterialTypeDropDown.FormattingEnabled = true;
            this.MaterialTypeDropDown.Items.AddRange(new object[] {
            "laminate",
            "oak",
            "rosewood",
            "veneer",
            "pine"});
            this.MaterialTypeDropDown.Location = new System.Drawing.Point(104, 520);
            this.MaterialTypeDropDown.Name = "MaterialTypeDropDown";
            this.MaterialTypeDropDown.Size = new System.Drawing.Size(183, 33);
            this.MaterialTypeDropDown.TabIndex = 9;
            // 
            // OrderTimeLabel
            // 
            this.OrderTimeLabel.AutoSize = true;
            this.OrderTimeLabel.Location = new System.Drawing.Point(99, 585);
            this.OrderTimeLabel.Name = "OrderTimeLabel";
            this.OrderTimeLabel.Size = new System.Drawing.Size(232, 25);
            this.OrderTimeLabel.TabIndex = 10;
            this.OrderTimeLabel.Text = "Order Processing Time";
            // 
            // OrderProcessingDropdown
            // 
            this.OrderProcessingDropdown.FormattingEnabled = true;
            this.OrderProcessingDropdown.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.OrderProcessingDropdown.Location = new System.Drawing.Point(104, 630);
            this.OrderProcessingDropdown.Name = "OrderProcessingDropdown";
            this.OrderProcessingDropdown.Size = new System.Drawing.Size(183, 33);
            this.OrderProcessingDropdown.TabIndex = 11;
            // 
            // SubmitOrder
            // 
            this.SubmitOrder.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SubmitOrder.Location = new System.Drawing.Point(548, 229);
            this.SubmitOrder.Name = "SubmitOrder";
            this.SubmitOrder.Size = new System.Drawing.Size(225, 111);
            this.SubmitOrder.TabIndex = 12;
            this.SubmitOrder.Text = "Submit Order";
            this.SubmitOrder.UseVisualStyleBackColor = true;
            this.SubmitOrder.Click += new System.EventHandler(this.SubmitOrder_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 729);
            this.Controls.Add(this.SubmitOrder);
            this.Controls.Add(this.OrderProcessingDropdown);
            this.Controls.Add(this.OrderTimeLabel);
            this.Controls.Add(this.MaterialTypeDropDown);
            this.Controls.Add(this.DrawerDropDown);
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.DrawersLabel);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.DepthTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DepthTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.Label DrawersLabel;
        private System.Windows.Forms.Label MaterialLabel;
        private System.Windows.Forms.ComboBox DrawerDropDown;
        private System.Windows.Forms.ComboBox MaterialTypeDropDown;
        private System.Windows.Forms.Label OrderTimeLabel;
        private System.Windows.Forms.ComboBox OrderProcessingDropdown;
        private System.Windows.Forms.Button SubmitOrder;
    }
}