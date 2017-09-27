using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopAPI.Models
{
    public class Category
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }

        public string Category_Name { get; set; }

        public string Category_Alias { get; set; }

        public string Category_Content { get; set; }

        public virtual IEnumerable<Category> Categorys { get; set; }
    }
}
