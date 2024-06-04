/* 
 * Nathan Doan - 20230825 
 * This application is an inventory management system that allows users to add, edit, and delete inventory items.
 */

using System;
using System.Collections;
using System.Windows.Forms;
using System.IO;

namespace InventoryManagementSystem
{
    public delegate void ItemAddedHandler(string itemName);
    public partial class Form1 : Form
    {
        ArrayList inventoryList = new ArrayList();
        ArrayList categoryList = new ArrayList();
        List<int> priceList = new List<int>();

        public event ItemAddedHandler ItemAdded;
        public Form1()
        {
            InitializeComponent();
            InitializeInventoryListView();
            showInventory();

            this.ItemAdded += OnItemAdded;
        }

        private void InitializeInventoryListView()
        {
            // Set the view of the listview to details
            listView1.View = View.Details;
            listView1.Columns.Add("Name", 100);
            listView1.Columns.Add("Description", 100);
            listView1.Columns.Add("Quantity", 100);
            listView1.Columns.Add("Price", 100);
            listView1.Columns.Add("Category", 100);
            listView1.Columns.Add("Supplier", 100);
            listView1.Columns.Add("Date", 100);
        }

        // Sample inventory items
        private void showInventory()
        {
            // Initialize the inventory list
            inventoryList.Add(new Inventory("Laptop", "Dell Laptop", 10, 50000, "Electronics", "Dell", "2021-09-01"));
            inventoryList.Add(new Inventory("Phone", "Samsung Phone", 20, 30000, "Electronics", "Samsung", "2021-09-01"));
            inventoryList.Add(new Inventory("Book", "Programming Book", 30, 500, "Books", "Amazon", "2021-09-01"));

            foreach (Inventory item in inventoryList)
            {
                ListViewItem lvi = new ListViewItem(item.Name);
                lvi.SubItems.Add(item.Description);
                lvi.SubItems.Add(item.Quantity.ToString());
                lvi.SubItems.Add(item.Price.ToString());
                lvi.SubItems.Add(item.Category);
                lvi.SubItems.Add(item.Supplier);
                lvi.SubItems.Add(item.Date);
                listView1.Items.Add(lvi);
            }
        }

        // Add button click event
        private void addButton_Click(object sender, EventArgs e)
        {
            // Check if any fields are empty
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(addDescription.Text) || string.IsNullOrEmpty(addQuantity.Text) || string.IsNullOrEmpty(addPrice.Text) || string.IsNullOrEmpty(categoryBox.Text) || string.IsNullOrEmpty(supplierBox.Text) || string.IsNullOrEmpty(datePicker.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var inventory = new Inventory(
                    nameBox.Text,
                    addDescription.Text,
                    Convert.ToInt32(addQuantity.Text),
                    Convert.ToDouble(addPrice.Text),
                    categoryBox.Text,
                    supplierBox.Text,
                    datePicker.Text
                );
                inventoryList.Add(inventory);
                ListViewItem lvi = new ListViewItem(inventory.Name);
                lvi.SubItems.Add(inventory.Description);
                lvi.SubItems.Add(inventory.Quantity.ToString());
                lvi.SubItems.Add(inventory.Price.ToString());
                lvi.SubItems.Add(inventory.Category);
                lvi.SubItems.Add(inventory.Supplier);
                lvi.SubItems.Add(inventory.Date);
                listView1.Items.Add(lvi);

                // Raise the ItemAdded event
                ItemAdded?.Invoke(inventory.Name);

                tabControl1.SelectedTab = showPage;
            }
        }
        // Event handler for the ItemAdded event
        private void OnItemAdded(string itemName)
        {
            MessageBox.Show($"Item '{itemName}' has been added to the inventory.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Edit button click event
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Inventory selectedItem = (Inventory)inventoryList[listView1.FocusedItem.Index];

                editName.Text = selectedItem.Name;
                editDescription.Text = selectedItem.Description;
                editQuantity.Text = selectedItem.Quantity.ToString();
                editPrice.Text = selectedItem.Price.ToString();
                editCategory.Text = selectedItem.Category;
                editSupplier.Text = selectedItem.Supplier;
                editDate.Text = selectedItem.Date;

                tabControl1.SelectedTab = editPage;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.FocusedItem.Index;
                Inventory selectedItem = (Inventory)inventoryList[index];

                selectedItem.updateItems(
                    editName.Text,
                    editDescription.Text,
                    Convert.ToInt32(editQuantity.Text),
                    Convert.ToDouble(editPrice.Text),
                    editCategory.Text,
                    editSupplier.Text,
                    editDate.Text);

                listView1.Items[index].SubItems[0].Text = selectedItem.Name;
                listView1.Items[index].SubItems[1].Text = selectedItem.Description;
                listView1.Items[index].SubItems[2].Text = selectedItem.Quantity.ToString();
                listView1.Items[index].SubItems[3].Text = selectedItem.Price.ToString();
                listView1.Items[index].SubItems[4].Text = selectedItem.Category;
                listView1.Items[index].SubItems[5].Text = selectedItem.Supplier;
                listView1.Items[index].SubItems[6].Text = selectedItem.Date;
                MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControl1.SelectedTab = showPage;
            }
        }

        // Cancel button click event
        private void cancelButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = showPage;
        }


        // Delete button click event
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.FocusedItem.Index;
                inventoryList.RemoveAt(index);
                listView1.Items[index].Remove();
            }

            MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tabControl1.SelectedTab = showPage;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.Title = "Save Inventory List";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (Inventory item in inventoryList)
                    {
                        sw.WriteLine(item.Name + "," + item.Description + "," + item.Quantity + "," + item.Price + "," + item.Category + "," + item.Supplier + "," + item.Date);
                    }
                }
                MessageBox.Show("Inventory list saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error saving inventory list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                categoryList.Add(textBox1.Text);
                categoryBox.Items.Add(textBox1.Text);
                editCategory.Items.Add(textBox1.Text);
                MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                supplierBox.Items.Add(textBox2.Text);
                MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
