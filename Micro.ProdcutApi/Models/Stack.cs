using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Micro.ProductApi.Models
{
    public class Stack
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Item")]
        public int ItemId { get; set; }
        public string Detials { get; set; }=string.Empty;

        [Range(0,int.MaxValue)]
        public int AvaQuantity { get; set; } = 0;

        [Range(0, double.MaxValue)]
        public double SellingPrice { get; set; } = 0;

        [Range(0, double.MaxValue)]
        public double CostPrice { get; set; } = 0;

        public virtual Item Item { get; set; } = null;
    }
}
