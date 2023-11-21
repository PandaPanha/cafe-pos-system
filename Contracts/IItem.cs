using cafe_pos_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_pos_system.Contracts
{
    public interface IItem
    {
        List<Item> GetItem();
        Item GetByItemById(int id);
        void InsertItem(Item item);
        void UpdateItem(Item item);
        void DeleteItemById(int id);
    }
}
