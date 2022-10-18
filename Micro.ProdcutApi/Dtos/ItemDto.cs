namespace Micro.ProductApi.Dtos
{
    public class ItemDto
    {
        public int Id { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } =string.Empty;
        public int CategoryId { get; set; } 

    }
}
