namespace RestaurantBill
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
            this.cmbDrinks = new System.Windows.Forms.ComboBox();
            this.cmbMeals = new System.Windows.Forms.ComboBox();
            this.cmbAppetizers = new System.Windows.Forms.ComboBox();
            this.cmbDesserts = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDrinks
            // 
            this.cmbDrinks.FormattingEnabled = true;
            this.cmbDrinks.Items.AddRange(new object[] {
            "Soda $1.95",
            "Tea $1.50",
            "Coffee $1.25",
            "Mineral Water $2.95",
            "Juice $2.50",
            "Milk $1.50"});
            this.cmbDrinks.Location = new System.Drawing.Point(13, 24);
            this.cmbDrinks.Name = "cmbDrinks";
            this.cmbDrinks.Size = new System.Drawing.Size(121, 21);
            this.cmbDrinks.TabIndex = 0;
            this.cmbDrinks.Text = "Beverages";
            this.cmbDrinks.SelectedIndexChanged += new System.EventHandler(this.dropdownSelection);
            // 
            // cmbMeals
            // 
            this.cmbMeals.FormattingEnabled = true;
            this.cmbMeals.Items.AddRange(new object[] {
            "Chicken Alfredo $13.95",
            "Chicken Picatta $13.95",
            "Turkey Club $11.95",
            "Lobster Pie $2.95",
            "Prime Rib $20.95",
            "Shrimp Scampi $18.95",
            "Turkey Dinner $13.95",
            "Stuffed Chicken $14.95",
            "Seafood Alfredo $15.55"});
            this.cmbMeals.Location = new System.Drawing.Point(180, 23);
            this.cmbMeals.Name = "cmbMeals";
            this.cmbMeals.Size = new System.Drawing.Size(121, 21);
            this.cmbMeals.TabIndex = 1;
            this.cmbMeals.Text = "Main Courses";
            this.cmbMeals.SelectedIndexChanged += new System.EventHandler(this.dropdownSelection);
            // 
            // cmbAppetizers
            // 
            this.cmbAppetizers.FormattingEnabled = true;
            this.cmbAppetizers.Items.AddRange(new object[] {
            "Buffalo Wings $5.95",
            "Buffalo Fingers $6.95",
            "Potato Skins $8.95",
            "Nachos $8.95",
            "Mushrooms Caps $ 10.95",
            "Shrimp Cocktail $12.95",
            "Chips and Salsa $6.95"});
            this.cmbAppetizers.Location = new System.Drawing.Point(13, 81);
            this.cmbAppetizers.Name = "cmbAppetizers";
            this.cmbAppetizers.Size = new System.Drawing.Size(121, 21);
            this.cmbAppetizers.TabIndex = 2;
            this.cmbAppetizers.Text = "Appetizers";
            this.cmbAppetizers.SelectedIndexChanged += new System.EventHandler(this.dropdownSelection);
            // 
            // cmbDesserts
            // 
            this.cmbDesserts.FormattingEnabled = true;
            this.cmbDesserts.Items.AddRange(new object[] {
            "Apple Pie $5.95",
            "Sundae $3.95",
            "Carrot Cake $5.95",
            "Mud Pie $4.95",
            "Apple Crisp $5.95"});
            this.cmbDesserts.Location = new System.Drawing.Point(180, 80);
            this.cmbDesserts.Name = "cmbDesserts";
            this.cmbDesserts.Size = new System.Drawing.Size(121, 21);
            this.cmbDesserts.TabIndex = 3;
            this.cmbDesserts.Text = "Desserts";
            this.cmbDesserts.SelectedIndexChanged += new System.EventHandler(this.dropdownSelection);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 132);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(288, 199);
            this.listBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmbDesserts);
            this.Controls.Add(this.cmbAppetizers);
            this.Controls.Add(this.cmbMeals);
            this.Controls.Add(this.cmbDrinks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDrinks;
        private System.Windows.Forms.ComboBox cmbMeals;
        private System.Windows.Forms.ComboBox cmbAppetizers;
        private System.Windows.Forms.ComboBox cmbDesserts;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

