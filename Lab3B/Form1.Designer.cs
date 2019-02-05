namespace Lab3B
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
            this.hairdresserGroupBox = new System.Windows.Forms.GroupBox();
            this.hairdresserComboBox = new System.Windows.Forms.ComboBox();
            this.serviceGroupBox = new System.Windows.Forms.GroupBox();
            this.serviceListBox = new System.Windows.Forms.ListBox();
            this.itemsGroupBox = new System.Windows.Forms.GroupBox();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.priceGroupBox = new System.Windows.Forms.GroupBox();
            this.priceListBox = new System.Windows.Forms.ListBox();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.calculateTotalButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.hairdresserGroupBox.SuspendLayout();
            this.serviceGroupBox.SuspendLayout();
            this.itemsGroupBox.SuspendLayout();
            this.priceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // hairdresserGroupBox
            // 
            this.hairdresserGroupBox.Controls.Add(this.hairdresserComboBox);
            this.hairdresserGroupBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hairdresserGroupBox.Location = new System.Drawing.Point(13, 13);
            this.hairdresserGroupBox.Name = "hairdresserGroupBox";
            this.hairdresserGroupBox.Size = new System.Drawing.Size(192, 193);
            this.hairdresserGroupBox.TabIndex = 0;
            this.hairdresserGroupBox.TabStop = false;
            this.hairdresserGroupBox.Text = "Select a Hairdresser:";
            // 
            // hairdresserComboBox
            // 
            this.hairdresserComboBox.FormattingEnabled = true;
            this.hairdresserComboBox.Items.AddRange(new object[] {
            "Jane Samley",
            "Pat Johnson",
            "Ron Chambers",
            "Sue Pallon",
            "Laura Renkins"});
            this.hairdresserComboBox.Location = new System.Drawing.Point(7, 22);
            this.hairdresserComboBox.Name = "hairdresserComboBox";
            this.hairdresserComboBox.Size = new System.Drawing.Size(179, 24);
            this.hairdresserComboBox.TabIndex = 0;
            this.hairdresserComboBox.Text = "Jane Samley";
            // 
            // serviceGroupBox
            // 
            this.serviceGroupBox.Controls.Add(this.serviceListBox);
            this.serviceGroupBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceGroupBox.Location = new System.Drawing.Point(228, 13);
            this.serviceGroupBox.Name = "serviceGroupBox";
            this.serviceGroupBox.Size = new System.Drawing.Size(225, 193);
            this.serviceGroupBox.TabIndex = 1;
            this.serviceGroupBox.TabStop = false;
            this.serviceGroupBox.Text = "Select a Service:";
            // 
            // serviceListBox
            // 
            this.serviceListBox.FormattingEnabled = true;
            this.serviceListBox.ItemHeight = 16;
            this.serviceListBox.Items.AddRange(new object[] {
            "Cut",
            "Wash, blow-dry, and style",
            "Colour",
            "Highlights",
            "Extensions",
            "Up-do"});
            this.serviceListBox.Location = new System.Drawing.Point(7, 22);
            this.serviceListBox.Name = "serviceListBox";
            this.serviceListBox.Size = new System.Drawing.Size(212, 164);
            this.serviceListBox.TabIndex = 0;
            this.serviceListBox.SelectedIndexChanged += new System.EventHandler(this.serviceListBox_SelectedIndexChanged);
            // 
            // itemsGroupBox
            // 
            this.itemsGroupBox.Controls.Add(this.itemsListBox);
            this.itemsGroupBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsGroupBox.Location = new System.Drawing.Point(467, 13);
            this.itemsGroupBox.Name = "itemsGroupBox";
            this.itemsGroupBox.Size = new System.Drawing.Size(223, 193);
            this.itemsGroupBox.TabIndex = 2;
            this.itemsGroupBox.TabStop = false;
            this.itemsGroupBox.Text = "Charged Items:";
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 16;
            this.itemsListBox.Location = new System.Drawing.Point(7, 22);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(210, 164);
            this.itemsListBox.TabIndex = 0;
            // 
            // priceGroupBox
            // 
            this.priceGroupBox.Controls.Add(this.priceListBox);
            this.priceGroupBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceGroupBox.Location = new System.Drawing.Point(696, 13);
            this.priceGroupBox.Name = "priceGroupBox";
            this.priceGroupBox.Size = new System.Drawing.Size(158, 193);
            this.priceGroupBox.TabIndex = 3;
            this.priceGroupBox.TabStop = false;
            this.priceGroupBox.Text = "Price:";
            // 
            // priceListBox
            // 
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.ItemHeight = 16;
            this.priceListBox.Location = new System.Drawing.Point(7, 22);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.Size = new System.Drawing.Size(145, 164);
            this.priceListBox.TabIndex = 0;
            // 
            // addServiceButton
            // 
            this.addServiceButton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addServiceButton.Location = new System.Drawing.Point(45, 261);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(174, 40);
            this.addServiceButton.TabIndex = 4;
            this.addServiceButton.Text = "Add Service";
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.addServiceButton_Click);
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTotalButton.Location = new System.Drawing.Point(228, 261);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(174, 40);
            this.calculateTotalButton.TabIndex = 5;
            this.calculateTotalButton.Text = "Calculate Total";
            this.calculateTotalButton.UseVisualStyleBackColor = true;
            this.calculateTotalButton.Click += new System.EventHandler(this.calculateTotalButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(408, 261);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(174, 40);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(588, 261);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(174, 40);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(515, 227);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(104, 16);
            this.totalPriceLabel.TabIndex = 8;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(625, 224);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(137, 22);
            this.totalTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 313);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calculateTotalButton);
            this.Controls.Add(this.addServiceButton);
            this.Controls.Add(this.priceGroupBox);
            this.Controls.Add(this.itemsGroupBox);
            this.Controls.Add(this.serviceGroupBox);
            this.Controls.Add(this.hairdresserGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfect Cut Hair Salon";
            this.hairdresserGroupBox.ResumeLayout(false);
            this.serviceGroupBox.ResumeLayout(false);
            this.itemsGroupBox.ResumeLayout(false);
            this.priceGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox hairdresserGroupBox;
        private System.Windows.Forms.GroupBox serviceGroupBox;
        private System.Windows.Forms.GroupBox itemsGroupBox;
        private System.Windows.Forms.GroupBox priceGroupBox;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Button calculateTotalButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.ComboBox hairdresserComboBox;
        private System.Windows.Forms.ListBox serviceListBox;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.ListBox priceListBox;
    }
}

