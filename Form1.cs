using System.Collections;

namespace InventoryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showInventory();

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

        ArrayList inventoryList = new ArrayList();

        private void showInventory()
        {
            Inventory laptop = new Inventory("Laptop", "Dell Laptop", 10, 50000, "Electronics", "Dell", "2021-09-01");
            Inventory phone = new Inventory("Phone", "Samsung Phone", 20, 30000, "Electronics", "Samsung", "2021-09-01");
            Inventory book = new Inventory("Book", "Programming Book", 30, 500, "Books", "Amazon", "2021-09-01");

            inventoryList.Add(laptop);
            inventoryList.Add(phone);
            inventoryList.Add(book);

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

        private void addButton_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory(nameBox.Text, addDescription.Text, Convert.ToInt32(addQuantity.Text), Convert.ToDouble(addPrice.Text), categoryBox.Text, supplierBox.Text, datePicker.Text);

            inventoryList.Add(inventory);
            ListViewItem lvi = new ListViewItem(inventory.Name);
            lvi.SubItems.Add(inventory.Description);
            lvi.SubItems.Add(inventory.Quantity.ToString());
            lvi.SubItems.Add(inventory.Price.ToString());
            lvi.SubItems.Add(inventory.Category);
            lvi.SubItems.Add(inventory.Supplier);
            lvi.SubItems.Add(inventory.Date);
            listView1.Items.Add(lvi);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
