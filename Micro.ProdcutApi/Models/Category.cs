
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Micro.ProductApi.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
