using AutoMapper;
using CustomerService.Domain;

namespace CustomerService.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //AutoMapper scans the properties of these two types for matching 
            CreateMap<Customer, CustomerResource>();
        }

    }
}
