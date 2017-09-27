using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopAPI.Models
{
    public class Product
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Product_Id { get; set; }

        public string Product_Name { get; set; }

        public string Product_Alias { get; set; }

        public int Category_Id { get; set; }

        [ForeignKey("Category_Id")]
        public virtual Category Category { get; set;  }

        public int Product_Cost { get; set; }

        public string Product_Detail { get; set; }

        public string Product_Image { get; set; }

        public bool Status { get; set; }
    }
}
