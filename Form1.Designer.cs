namespace InventoryManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            showPage = new TabPage();
            listView1 = new ListView();
            addPage = new TabPage();
            addQuantity = new NumericUpDown();
            addPrice = new TextBox();
            cancelButton = new Button();
            addButton = new Button();
            datePicker = new DateTimePicker();
            supplierBox = new ListBox();
            categoryBox = new ComboBox();
            addDescription = new TextBox();
            nameBox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            editPage = new TabPage();
            updateButton = new Button();
            editDescription = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            editDate = new DateTimePicker();
            editSupplier = new ListBox();
            editCategory = new ComboBox();
            editPrice = new TextBox();
            editQuantity = new TextBox();
            editName = new TextBox();
            tabControl1.SuspendLayout();
            showPage.SuspendLayout();
            addPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addQuantity).BeginInit();
            editPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(showPage);
            tabControl1.Controls.Add(addPage);
            tabControl1.Controls.Add(editPage);
            tabControl1.Location = new Point(-1, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(802, 496);
            tabControl1.TabIndex = 0;
            // 
            // showPage
            // 
            showPage.Controls.Add(listView1);
            showPage.Location = new Point(4, 24);
            showPage.Name = "showPage";
            showPage.Padding = new Padding(3);
            showPage.Size = new Size(794, 468);
            showPage.TabIndex = 0;
            showPage.Text = "Show Inventory";
            showPage.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(794, 422);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // addPage
            // 
            addPage.Controls.Add(addQuantity);
            addPage.Controls.Add(addPrice);
            addPage.Controls.Add(cancelButton);
            addPage.Controls.Add(addButton);
            addPage.Controls.Add(datePicker);
            addPage.Controls.Add(supplierBox);
            addPage.Controls.Add(categoryBox);
            addPage.Controls.Add(addDescription);
            addPage.Controls.Add(nameBox);
            addPage.Controls.Add(label8);
            addPage.Controls.Add(label7);
            addPage.Controls.Add(label6);
            addPage.Controls.Add(label5);
            addPage.Controls.Add(label4);
            addPage.Controls.Add(label3);
            addPage.Controls.Add(label2);
            addPage.Controls.Add(label1);
            addPage.Location = new Point(4, 24);
            addPage.Name = "addPage";
            addPage.Padding = new Padding(3);
            addPage.Size = new Size(794, 468);
            addPage.TabIndex = 1;
            addPage.Text = "Add Inventory";
            addPage.UseVisualStyleBackColor = true;
            // 
            // addQuantity
            // 
            addQuantity.Location = new Point(131, 133);
            addQuantity.Name = "addQuantity";
            addQuantity.Size = new Size(120, 23);
            addQuantity.TabIndex = 22;
            // 
            // addPrice
            // 
            addPrice.Location = new Point(131, 186);
            addPrice.Name = "addPrice";
            addPrice.Size = new Size(151, 23);
            addPrice.TabIndex = 21;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(389, 414);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(95, 28);
            cancelButton.TabIndex = 19;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(207, 414);
            addButton.Name = "addButton";
            addButton.Size = new Size(95, 28);
            addButton.TabIndex = 18;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(556, 190);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 23);
            datePicker.TabIndex = 17;
            // 
            // supplierBox
            // 
            supplierBox.FormattingEnabled = true;
            supplierBox.ItemHeight = 15;
            supplierBox.Items.AddRange(new object[] { "Amazon", "Dell", "Supermarket", "Gucci" });
            supplierBox.Location = new Point(556, 130);
            supplierBox.Name = "supplierBox";
            supplierBox.Size = new Size(135, 34);
            supplierBox.TabIndex = 16;
            // 
            // categoryBox
            // 
            categoryBox.FormattingEnabled = true;
            categoryBox.Items.AddRange(new object[] { "Groceries", "Tech", "Beauty" });
            categoryBox.Location = new Point(556, 77);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(135, 23);
            categoryBox.TabIndex = 14;
            // 
            // addDescription
            // 
            addDescription.Location = new Point(52, 288);
            addDescription.Multiline = true;
            addDescription.Name = "addDescription";
            addDescription.Size = new Size(639, 102);
            addDescription.TabIndex = 11;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(117, 79);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(151, 23);
            nameBox.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(488, 188);
            label8.Name = "label8";
            label8.Size = new Size(45, 21);
            label8.TabIndex = 7;
            label8.Text = "Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(474, 130);
            label7.Name = "label7";
            label7.Size = new Size(71, 21);
            label7.TabIndex = 6;
            label7.Text = "Supplier:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(474, 77);
            label6.Name = "label6";
            label6.Size = new Size(76, 21);
            label6.TabIndex = 5;
            label6.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(52, 248);
            label5.Name = "label5";
            label5.Size = new Size(92, 21);
            label5.TabIndex = 4;
            label5.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(52, 188);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 3;
            label4.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(52, 130);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 2;
            label3.Text = "Quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(52, 77);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 1;
            label2.Text = "Name: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(258, 14);
            label1.Name = "label1";
            label1.Size = new Size(198, 40);
            label1.TabIndex = 0;
            label1.Text = "Add Inventory";
            // 
            // editPage
            // 
            editPage.Controls.Add(updateButton);
            editPage.Controls.Add(editDate);
            editPage.Controls.Add(editSupplier);
            editPage.Controls.Add(editCategory);
            editPage.Controls.Add(editDescription);
            editPage.Controls.Add(editPrice);
            editPage.Controls.Add(editQuantity);
            editPage.Controls.Add(editName);
            editPage.Controls.Add(label9);
            editPage.Controls.Add(label10);
            editPage.Controls.Add(label11);
            editPage.Controls.Add(label12);
            editPage.Controls.Add(label13);
            editPage.Controls.Add(label14);
            editPage.Controls.Add(label15);
            editPage.Controls.Add(label16);
            editPage.Location = new Point(4, 24);
            editPage.Name = "editPage";
            editPage.Padding = new Padding(3);
            editPage.Size = new Size(794, 468);
            editPage.TabIndex = 2;
            editPage.Text = "Edit Inventory";
            editPage.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(317, 418);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(95, 28);
            updateButton.TabIndex = 33;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // editDescription
            // 
            editDescription.Location = new Point(45, 297);
            editDescription.Multiline = true;
            editDescription.Name = "editDescription";
            editDescription.Size = new Size(639, 102);
            editDescription.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(481, 197);
            label9.Name = "label9";
            label9.Size = new Size(45, 21);
            label9.TabIndex = 25;
            label9.Text = "Date:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(467, 139);
            label10.Name = "label10";
            label10.Size = new Size(71, 21);
            label10.TabIndex = 24;
            label10.Text = "Supplier:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(467, 86);
            label11.Name = "label11";
            label11.Size = new Size(76, 21);
            label11.TabIndex = 23;
            label11.Text = "Category:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(45, 257);
            label12.Name = "label12";
            label12.Size = new Size(92, 21);
            label12.TabIndex = 22;
            label12.Text = "Description:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(45, 197);
            label13.Name = "label13";
            label13.Size = new Size(47, 21);
            label13.TabIndex = 21;
            label13.Text = "Price:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(45, 139);
            label14.Name = "label14";
            label14.Size = new Size(73, 21);
            label14.TabIndex = 20;
            label14.Text = "Quantity:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F);
            label15.Location = new Point(45, 86);
            label15.Name = "label15";
            label15.Size = new Size(59, 21);
            label15.TabIndex = 19;
            label15.Text = "Name: ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(251, 23);
            label16.Name = "label16";
            label16.Size = new Size(194, 40);
            label16.TabIndex = 18;
            label16.Text = "Edit Inventory";
            // 
            // editDate
            // 
            editDate.Location = new Point(549, 199);
            editDate.Name = "editDate";
            editDate.Size = new Size(200, 23);
            editDate.TabIndex = 32;
            // 
            // editSupplier
            // 
            editSupplier.FormattingEnabled = true;
            editSupplier.ItemHeight = 15;
            editSupplier.Location = new Point(549, 139);
            editSupplier.Name = "editSupplier";
            editSupplier.Size = new Size(135, 34);
            editSupplier.TabIndex = 31;
            // 
            // editCategory
            // 
            editCategory.FormattingEnabled = true;
            editCategory.Location = new Point(549, 86);
            editCategory.Name = "editCategory";
            editCategory.Size = new Size(135, 23);
            editCategory.TabIndex = 30;
            // 
            // editPrice
            // 
            editPrice.Location = new Point(110, 199);
            editPrice.Name = "editPrice";
            editPrice.Size = new Size(151, 23);
            editPrice.TabIndex = 28;
            // 
            // editQuantity
            // 
            editQuantity.Location = new Point(124, 139);
            editQuantity.Name = "editQuantity";
            editQuantity.Size = new Size(151, 23);
            editQuantity.TabIndex = 27;
            // 
            // editName
            // 
            editName.Location = new Point(110, 88);
            editName.Name = "editName";
            editName.Size = new Size(151, 23);
            editName.TabIndex = 26;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 498);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Inventory Management System";
            tabControl1.ResumeLayout(false);
            showPage.ResumeLayout(false);
            addPage.ResumeLayout(false);
            addPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addQuantity).EndInit();
            editPage.ResumeLayout(false);
            editPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage showPage;
        private ListView listView1;
        private TabPage addPage;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label6;
        private MonthCalendar monthCalendar1;
        private ComboBox categoryBox;
        private TextBox addDescription;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox nameBox;
        private DateTimePicker datePicker;
        private ListBox supplierBox;
        private TabPage editPage;
        private TextBox editDescription;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button cancelButton;
        private Button addButton;
        private Button updateButton;
        private TextBox addPrice;
        private NumericUpDown addQuantity;
        private DateTimePicker editDate;
        private ListBox editSupplier;
        private ComboBox editCategory;
        private TextBox editPrice;
        private TextBox editQuantity;
        private TextBox editName;
    }
}
