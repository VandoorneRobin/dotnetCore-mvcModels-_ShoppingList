using System;

namespace Classes
{
    public class Item
    {
        public Item(string naam, int aantal )
        {
            this.Naam = naam;
            this.Aantal = aantal;
        }

        public string Naam { get; set; }
        public int Aantal { get; set; }
    }
}
