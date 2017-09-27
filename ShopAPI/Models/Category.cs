using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopAPI.Models
{
    public class Category
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        [Column(Order = 1)]
        public int Category_Id { get; set; }

        public string Category_Name { get; set; }

        public string Category_Alias { get; set; }

        public string Category_Content { get; set; }

    }
}
