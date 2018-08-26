using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
   public class ShoppingList
    {
        public List<Item> items;

        public ShoppingList()
        {
            
        }
        
        public void addItem(string naam, int aantal)
        {
            items.Add(new Item(naam, aantal));
        }
    }
}

