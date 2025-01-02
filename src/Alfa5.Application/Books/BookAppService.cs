using System;
using Alfa5.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Alfa5.Books;

public class BookAppService :
    CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
        GetPolicyName = Alfa5Permissions.Books.Default;
        GetListPolicyName = Alfa5Permissions.Books.Default;
        CreatePolicyName = Alfa5Permissions.Books.Create;
        UpdatePolicyName = Alfa5Permissions.Books.Edit;
        DeletePolicyName = Alfa5Permissions.Books.Delete;
    }
}