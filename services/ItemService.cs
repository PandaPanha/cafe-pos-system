using cafe_pos_system.Contracts;
using cafe_pos_system.DB;
using cafe_pos_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_pos_system.services
{
    public class ItemService : IItem
    {
        private ItemDB itemDB = new ItemDB();
        public void DeleteItemById(int id)
        {
            itemDB.DeleteItemById(id);
        }

        public Item GetByItemById(int id)
        {
            return itemDB.GetByItemById(id);
        }

        public List<Item> GetItem()
        {
            return itemDB.GetItem();
        }

        public void InsertItem(Item item)
        {
            itemDB.InsertItem(item);
        }

        public void UpdateItem(Item item)
        {
            itemDB.UpdateItem(item);
        }

        public int GetSoldCups()
        {
            List<Item> items = itemDB.GetItem();
            int soldCups = 0;
            foreach (Item item in items)
            {
                soldCups += item.SoldQty;
            }
            return soldCups;
        }

        public string GetPopularDrink()
        {
            try
            {
                List<Item> items = itemDB.GetItem();

                // Using LINQ, order the items in descending order based on SoldQty and select the first item
                Item popularItem = new Item();
                popularItem = items.OrderByDescending(item => item.SoldQty).First();

                // Return the name of the most popular item
                return popularItem.Name;

                /*
                1. **Retrieve Items**: It retrieves a list of items from the `itemDB` (presumably an instance of a database accessor or repository).
                2. **LINQ Query**:
                   - It uses LINQ (Language Integrated Query) to perform operations on the list of items.
                   - `OrderByDescending` arranges the items in descending order based on the `SoldQty` property.
                   - `First()` retrieves the first item from the ordered list, which, in this case, would be the item with the highest `SoldQty`.
                3. **Return**: It returns the `Name` property of the most popular item.

                Therefore, this code fetches a list of items, finds the item that has been sold the most (by `SoldQty`), and returns the name of that particular item.
                */
            }
            catch(Exception ex)
            {
                MessageBox.Show("Item not found!");
                return string.Empty;
            }
        }
    }
}
