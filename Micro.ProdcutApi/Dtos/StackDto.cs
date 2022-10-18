namespace Micro.ProductApi.Dtos
{
    public class StackDto
    {
        public int Id { get; set; }

     
        public int ItemId { get; set; }
        public string Detials { get; set; } 
        public int AvaQuantity { get; set; } 
        public double SellingPrice { get; set; } 
        public double CostPrice { get; set; } 
    }
}
