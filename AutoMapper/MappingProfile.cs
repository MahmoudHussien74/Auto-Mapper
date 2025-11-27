using AutoMapper;
using AutoMapper.Model;

namespace Auto_Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDto>()
                .ForMember(dest => dest.IsFree, src => src.MapFrom(src => src.price == 0))
                .ReverseMap();
                
        }
    }
}
