using AutoMapper;
using Alfa5.Books;

namespace Alfa5.Blazor;

public class Alfa5BlazorAutoMapperProfile : Profile
{
    public Alfa5BlazorAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        //Define your AutoMapper configuration here for the Blazor project.
    }
}
