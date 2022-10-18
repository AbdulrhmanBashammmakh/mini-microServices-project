using AutoMapper;
using SaleApi.Dtos;
using SaleApi.Models;

namespace Micro.SaleApi.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CustomerDto, Customer>().ReverseMap();
        }
    }
}
