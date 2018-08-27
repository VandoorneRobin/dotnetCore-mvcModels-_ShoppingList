using System;
using System.ComponentModel.DataAnnotations;

namespace dotnetCore_mvcModels__ShoppingList.Entities
{
    public partial class ShopItem
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [Required(ErrorMessage ="Please enter text for {0}")]
        public string Item { get; set; }

        [Required(ErrorMessage = " Please enter a value for {0}")]
        [Range(minimum:1, maximum:5, ErrorMessage= "Please enter a value for {0} between {1} and {5}")]
        public byte Quantity { get; set; }
    }
}
