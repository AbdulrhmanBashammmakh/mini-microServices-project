using AutoMapper;
using Micro.ProductApi.Dtos;
using Micro.ProductApi.Models;

namespace Micro.ProdcutApi.auto
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
              CreateMap<ItemDto, Item>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<StackDto, Stack>().ReverseMap();


        }
    }
}