using AutoMapper;
using FilosoPediaWeb.Api.Mapper;
using FilosoPediaWeb.Api.Models;

namespace FIlosoPediaWeb.Api.Mapper.Mapping;
public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<Author, AuthorDTO>().ReverseMap();
        CreateMap<Book, BookDTO>().ReverseMap();
        CreateMap<Gender, GenderDTO>().ReverseMap();
        CreateMap<Comentary, ComentaryDTO>().ReverseMap();
    }
}
