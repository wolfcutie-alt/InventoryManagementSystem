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
            panel3 = new Panel();
            listView1 = new ListView();
            saveBtn = new Button();
            addPage = new TabPage();
            panel4 = new Panel();
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
            deleteBtn = new Button();
            editQuantity = new NumericUpDown();
            editSupplier = new TextBox();
            updateButton = new Button();
            editDate = new DateTimePicker();
            editCategory = new ComboBox();
            editDescription = new TextBox();
            editPrice = new TextBox();
            editName = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            addCategory = new TabPage();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            textBox1 = new TextBox();
            label18 = new Label();
            label17 = new Label();
            addSupplier = new TabPage();
            panel2 = new Panel();
            linkLabel3 = new LinkLabel();
            button2 = new Button();
            textBox2 = new TextBox();
            label19 = new Label();
            label20 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            button3 = new Button();
            tabControl1.SuspendLayout();
            showPage.SuspendLayout();
            panel3.SuspendLayout();
            addPage.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addQuantity).BeginInit();
            editPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)editQuantity).BeginInit();
            addCategory.SuspendLayout();
            panel1.SuspendLayout();
            addSupplier.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(showPage);
            tabControl1.Controls.Add(addPage);
            tabControl1.Controls.Add(editPage);
            tabControl1.Controls.Add(addCategory);
            tabControl1.Controls.Add(addSupplier);
            tabControl1.Location = new Point(-1, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(802, 496);
            tabControl1.TabIndex = 0;
            // 
            // showPage
            // 
            showPage.Controls.Add(panel3);
            showPage.Controls.Add(saveBtn);
            showPage.Location = new Point(4, 24);
            showPage.Name = "showPage";
            showPage.Padding = new Padding(3);
            showPage.Size = new Size(794, 468);
            showPage.TabIndex = 0;
            showPage.Text = "Show Inventory";
            showPage.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(listView1);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(794, 422);
            panel3.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Location = new Point(-3, -3);
            listView1.Name = "listView1";
            listView1.Size = new Size(794, 422);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(304, 437);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(106, 23);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // addPage
            // 
            addPage.Controls.Add(panel4);
            addPage.Location = new Point(4, 24);
            addPage.Name = "addPage";
            addPage.Padding = new Padding(3);
            addPage.Size = new Size(794, 468);
            addPage.TabIndex = 1;
            addPage.Text = "Add Inventory";
            addPage.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Controls.Add(addQuantity);
            panel4.Controls.Add(addPrice);
            panel4.Controls.Add(cancelButton);
            panel4.Controls.Add(addButton);
            panel4.Controls.Add(datePicker);
            panel4.Controls.Add(supplierBox);
            panel4.Controls.Add(categoryBox);
            panel4.Controls.Add(addDescription);
            panel4.Controls.Add(nameBox);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(791, 465);
            panel4.TabIndex = 0;
            // 
            // addQuantity
            // 
            addQuantity.Location = new Point(122, 137);
            addQuantity.Name = "addQuantity";
            addQuantity.Size = new Size(120, 23);
            addQuantity.TabIndex = 39;
            // 
            // addPrice
            // 
            addPrice.Location = new Point(122, 190);
            addPrice.Name = "addPrice";
            addPrice.Size = new Size(151, 23);
            addPrice.TabIndex = 38;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(380, 418);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(95, 28);
            cancelButton.TabIndex = 37;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(198, 418);
            addButton.Name = "addButton";
            addButton.Size = new Size(95, 28);
            addButton.TabIndex = 36;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(547, 194);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 23);
            datePicker.TabIndex = 35;
            // 
            // supplierBox
            // 
            supplierBox.FormattingEnabled = true;
            supplierBox.ItemHeight = 15;
            supplierBox.Items.AddRange(new object[] { "Amazon", "Dell", "Supermarket", "Gucci" });
            supplierBox.Location = new Point(547, 134);
            supplierBox.Name = "supplierBox";
            supplierBox.Size = new Size(135, 34);
            supplierBox.TabIndex = 34;
            // 
            // categoryBox
            // 
            categoryBox.FormattingEnabled = true;
            categoryBox.Items.AddRange(new object[] { "Groceries", "Tech", "Beauty" });
            categoryBox.Location = new Point(547, 81);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(135, 23);
            categoryBox.TabIndex = 33;
            // 
            // addDescription
            // 
            addDescription.Location = new Point(43, 292);
            addDescription.Multiline = true;
            addDescription.Name = "addDescription";
            addDescription.Size = new Size(639, 102);
            addDescription.TabIndex = 32;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(108, 83);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(151, 23);
            nameBox.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(479, 192);
            label8.Name = "label8";
            label8.Size = new Size(45, 21);
            label8.TabIndex = 30;
            label8.Text = "Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(465, 134);
            label7.Name = "label7";
            label7.Size = new Size(71, 21);
            label7.TabIndex = 29;
            label7.Text = "Supplier:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(465, 81);
            label6.Name = "label6";
            label6.Size = new Size(76, 21);
            label6.TabIndex = 28;
            label6.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(43, 252);
            label5.Name = "label5";
            label5.Size = new Size(92, 21);
            label5.TabIndex = 27;
            label5.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(43, 192);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 26;
            label4.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(43, 134);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 25;
            label3.Text = "Quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(43, 81);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 24;
            label2.Text = "Name: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 18);
            label1.Name = "label1";
            label1.Size = new Size(198, 40);
            label1.TabIndex = 23;
            label1.Text = "Add Inventory";
            // 
            // editPage
            // 
            editPage.Controls.Add(deleteBtn);
            editPage.Controls.Add(editQuantity);
            editPage.Controls.Add(editSupplier);
            editPage.Controls.Add(updateButton);
            editPage.Controls.Add(editDate);
            editPage.Controls.Add(editCategory);
            editPage.Controls.Add(editDescription);
            editPage.Controls.Add(editPrice);
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
            // deleteBtn
            // 
            deleteBtn.Location = new Point(467, 418);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(95, 28);
            deleteBtn.TabIndex = 36;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // editQuantity
            // 
            editQuantity.Location = new Point(124, 142);
            editQuantity.Name = "editQuantity";
            editQuantity.Size = new Size(120, 23);
            editQuantity.TabIndex = 35;
            // 
            // editSupplier
            // 
            editSupplier.Location = new Point(549, 141);
            editSupplier.Name = "editSupplier";
            editSupplier.Size = new Size(151, 23);
            editSupplier.TabIndex = 34;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(166, 418);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(95, 28);
            updateButton.TabIndex = 33;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // editDate
            // 
            editDate.Location = new Point(549, 199);
            editDate.Name = "editDate";
            editDate.Size = new Size(200, 23);
            editDate.TabIndex = 32;
            // 
            // editCategory
            // 
            editCategory.FormattingEnabled = true;
            editCategory.Location = new Point(549, 86);
            editCategory.Name = "editCategory";
            editCategory.Size = new Size(135, 23);
            editCategory.TabIndex = 30;
            // 
            // editDescription
            // 
            editDescription.Location = new Point(45, 297);
            editDescription.Multiline = true;
            editDescription.Name = "editDescription";
            editDescription.Size = new Size(639, 102);
            editDescription.TabIndex = 29;
            // 
            // editPrice
            // 
            editPrice.Location = new Point(110, 199);
            editPrice.Name = "editPrice";
            editPrice.Size = new Size(151, 23);
            editPrice.TabIndex = 28;
            // 
            // editName
            // 
            editName.Location = new Point(110, 88);
            editName.Name = "editName";
            editName.Size = new Size(151, 23);
            editName.TabIndex = 26;
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
            // addCategory
            // 
            addCategory.Controls.Add(panel1);
            addCategory.Location = new Point(4, 24);
            addCategory.Name = "addCategory";
            addCategory.Padding = new Padding(3);
            addCategory.Size = new Size(794, 468);
            addCategory.TabIndex = 3;
            addCategory.Text = "Add Category";
            addCategory.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label17);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 468);
            panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(315, 274);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(43, 15);
            linkLabel1.TabIndex = 20;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cancel";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(252, 220);
            button1.Name = "button1";
            button1.Size = new Size(191, 28);
            button1.TabIndex = 19;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(295, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 23);
            textBox1.TabIndex = 10;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F);
            label18.Location = new Point(230, 114);
            label18.Name = "label18";
            label18.Size = new Size(59, 21);
            label18.TabIndex = 9;
            label18.Text = "Name: ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(252, 34);
            label17.Name = "label17";
            label17.Size = new Size(194, 40);
            label17.TabIndex = 1;
            label17.Text = "Add Category";
            // 
            // addSupplier
            // 
            addSupplier.Controls.Add(panel2);
            addSupplier.Location = new Point(4, 24);
            addSupplier.Name = "addSupplier";
            addSupplier.Padding = new Padding(3);
            addSupplier.Size = new Size(794, 468);
            addSupplier.TabIndex = 4;
            addSupplier.Text = "Add Supplier";
            addSupplier.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(linkLabel3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label20);
            panel2.Location = new Point(2, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(791, 468);
            panel2.TabIndex = 1;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(332, 299);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(43, 15);
            linkLabel3.TabIndex = 24;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Cancel";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // button2
            // 
            button2.Location = new Point(261, 242);
            button2.Name = "button2";
            button2.Size = new Size(191, 28);
            button2.TabIndex = 23;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(304, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 23);
            textBox2.TabIndex = 22;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F);
            label19.Location = new Point(239, 136);
            label19.Name = "label19";
            label19.Size = new Size(59, 21);
            label19.TabIndex = 21;
            label19.Text = "Name: ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(261, 56);
            label20.Name = "label20";
            label20.Size = new Size(182, 40);
            label20.TabIndex = 20;
            label20.Text = "Add Supplier";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            button3.Location = new Point(547, 418);
            button3.Name = "button3";
            button3.Size = new Size(95, 28);
            button3.TabIndex = 40;
            button3.Text = "Import";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            panel3.ResumeLayout(false);
            addPage.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addQuantity).EndInit();
            editPage.ResumeLayout(false);
            editPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)editQuantity).EndInit();
            addCategory.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            addSupplier.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage showPage;
        private TabPage addPage;
        private MonthCalendar monthCalendar1;
        private TextBox textBox3;
        private TextBox textBox2;
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
        private Button updateButton;
        private DateTimePicker editDate;
        private ComboBox editCategory;
        private TextBox editPrice;
        private TextBox editName;
        private TextBox editSupplier;
        private NumericUpDown editQuantity;
        private Button deleteBtn;
        private Button saveBtn;
        private SaveFileDialog saveFileDialog1;
        private TabPage addCategory;
        private Panel panel1;
        private Label label17;
        private TabPage addSupplier;
        private Panel panel2;
        private Button button1;
        private TextBox textBox1;
        private Label label18;
        private Button button2;
        private Label label19;
        private Label label20;
        private Panel panel3;
        private ListView listView1;
        private Panel panel4;
        private NumericUpDown addQuantity;
        private TextBox addPrice;
        private Button cancelButton;
        private Button addButton;
        private DateTimePicker datePicker;
        private ListBox supplierBox;
        private ComboBox categoryBox;
        private TextBox addDescription;
        private TextBox nameBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel3;
        private Button button3;
        private OpenFileDialog openFileDialog1;
    }
}
