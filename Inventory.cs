using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    internal class Inventory
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string Supplier { get; set; }
        public string Date { get; set; }

        public Inventory(string name, string description, int quantity, double price, string category, string supplier, string date)
        {
            this.Name = name;
            this.Description = description;
            this.Quantity = quantity;
            this.Price = price;
            this.Category = category;
            this.Supplier = supplier;
            this.Date = date;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
