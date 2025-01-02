using AutoMapper;
using Alfa5.Books;

namespace Alfa5;

public class Alfa5ApplicationAutoMapperProfile : Profile
{
    public Alfa5ApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
