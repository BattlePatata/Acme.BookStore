using Acme.BookStore.Books;
using Xunit;

namespace Acme.BookStore.EntityFrameworkCore.Applications.Books;
[Collection(BookStoreTestConsts.CollectionDefinitionName)]
public class BookAppService_Tests 
    : BookAppService_Tests<BookStoreEntityFrameworkCoreTestModule> {
}
