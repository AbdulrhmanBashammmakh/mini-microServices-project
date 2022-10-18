using AutoMapper;
using Micro.PurchaseApi.Dtos;
using Micro.PurchaseApi.Models;

namespace Micro.PurchaseApi.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<VendorDto, Vendor>().ReverseMap();
        }
    }
}
