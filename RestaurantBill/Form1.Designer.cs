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
            this.Beverage = new System.Windows.Forms.ComboBox();
            this.Appetizer = new System.Windows.Forms.ComboBox();
            this.MainCourse = new System.Windows.Forms.ComboBox();
            this.Dessert = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubTotal = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ClearBill = new System.Windows.Forms.Button();
            this.TableNumber = new System.Windows.Forms.TextBox();
            this.WaiterName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Beverage
            // 
            this.Beverage.FormattingEnabled = true;
            this.Beverage.Items.AddRange(new object[] {
            "Soda",
            "Tea",
            "Coffee",
            "Mineral Water",
            "Juice",
            "Milk"});
            this.Beverage.Location = new System.Drawing.Point(203, 216);
            this.Beverage.Name = "Beverage";
            this.Beverage.Size = new System.Drawing.Size(121, 21);
            this.Beverage.TabIndex = 0;
            this.Beverage.SelectedIndexChanged += new System.EventHandler(this.Beverage_SelectedIndexChanged);
            // 
            // Appetizer
            // 
            this.Appetizer.FormattingEnabled = true;
            this.Appetizer.Items.AddRange(new object[] {
            "Buffalo Wings",
            "Buffalo Fingers",
            "Potato Skins ",
            "Nachos",
            "Mushroom Caps",
            "Shrimp Cocktail ",
            "Chips and Salsa"});
            this.Appetizer.Location = new System.Drawing.Point(203, 243);
            this.Appetizer.Name = "Appetizer";
            this.Appetizer.Size = new System.Drawing.Size(121, 21);
            this.Appetizer.TabIndex = 1;
            this.Appetizer.SelectedIndexChanged += new System.EventHandler(this.Appetizer_SelectedIndexChanged);
            // 
            // MainCourse
            // 
            this.MainCourse.FormattingEnabled = true;
            this.MainCourse.Items.AddRange(new object[] {
            "Chicken Alfredo",
            "Chicken Picatta",
            "Turkey Club",
            "Lobster Pie",
            "Prime Rib",
            "Shrimp Scampi",
            "Turkey Dinner",
            "Stuffed Chicken"});
            this.MainCourse.Location = new System.Drawing.Point(203, 270);
            this.MainCourse.Name = "MainCourse";
            this.MainCourse.Size = new System.Drawing.Size(121, 21);
            this.MainCourse.TabIndex = 2;
            this.MainCourse.SelectedIndexChanged += new System.EventHandler(this.MainCourse_SelectedIndexChanged);
            // 
            // Dessert
            // 
            this.Dessert.FormattingEnabled = true;
            this.Dessert.Items.AddRange(new object[] {
            "Apple Pie",
            "Sundae",
            "Carrot Cake",
            "Mud Pie",
            "Apple Crisp"});
            this.Dessert.Location = new System.Drawing.Point(203, 297);
            this.Dessert.Name = "Dessert";
            this.Dessert.Size = new System.Drawing.Size(121, 21);
            this.Dessert.TabIndex = 3;
            this.Dessert.SelectedIndexChanged += new System.EventHandler(this.Dessert_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Waiter information\r\n        Table number:";
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSize = true;
            this.SubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotal.Location = new System.Drawing.Point(90, 396);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(70, 18);
            this.SubTotal.TabIndex = 5;
            this.SubTotal.Text = "Subtotal";
            // 
            // Tax
            // 
            this.Tax.AutoSize = true;
            this.Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tax.Location = new System.Drawing.Point(102, 431);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(35, 18);
            this.Tax.TabIndex = 6;
            this.Tax.Text = "Tax";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(102, 464);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(46, 18);
            this.Total.TabIndex = 7;
            this.Total.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Beverage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Appetizer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Main Course";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Dessert";
            // 
            // ClearBill
            // 
            this.ClearBill.Location = new System.Drawing.Point(145, 343);
            this.ClearBill.Name = "ClearBill";
            this.ClearBill.Size = new System.Drawing.Size(75, 23);
            this.ClearBill.TabIndex = 12;
            this.ClearBill.Text = "Clear Bill";
            this.ClearBill.UseVisualStyleBackColor = true;
            this.ClearBill.Click += new System.EventHandler(this.ClearBill_Click);
            // 
            // TableNumber
            // 
            this.TableNumber.Location = new System.Drawing.Point(224, 110);
            this.TableNumber.Name = "TableNumber";
            this.TableNumber.Size = new System.Drawing.Size(100, 20);
            this.TableNumber.TabIndex = 16;
            // 
            // WaiterName
            // 
            this.WaiterName.Location = new System.Drawing.Point(224, 156);
            this.WaiterName.Name = "WaiterName";
            this.WaiterName.Size = new System.Drawing.Size(100, 20);
            this.WaiterName.TabIndex = 17;
            this.WaiterName.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Waiter Name:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Restaurant";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 556);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WaiterName);
            this.Controls.Add(this.TableNumber);
            this.Controls.Add(this.ClearBill);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.SubTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dessert);
            this.Controls.Add(this.MainCourse);
            this.Controls.Add(this.Appetizer);
            this.Controls.Add(this.Beverage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Beverage;
        private System.Windows.Forms.ComboBox Appetizer;
        private System.Windows.Forms.ComboBox MainCourse;
        private System.Windows.Forms.ComboBox Dessert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SubTotal;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ClearBill;
        private System.Windows.Forms.TextBox TableNumber;
        private System.Windows.Forms.TextBox WaiterName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

