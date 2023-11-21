using cafe_pos_system.Contracts;
using cafe_pos_system.DB;
using cafe_pos_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_pos_system.services
{
    public class ItemService : IItem
    {
        private ItemDB itemDB = new ItemDB();
        public void DeleteItemById(int id)
        {
            throw new NotImplementedException();
        }

        public Item GetByItemById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Item> GetItem()
        {
            throw new NotImplementedException();
        }

        public void InsertItem(Item item)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
