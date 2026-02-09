

using AutoMapper;
using TechNest.BLL.ModelVM;
using TechNest.DAL.Entity;

namespace TechNest.BLL.AutoMapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<GetProductVM,Product>().ReverseMap();
        }
    }
}
