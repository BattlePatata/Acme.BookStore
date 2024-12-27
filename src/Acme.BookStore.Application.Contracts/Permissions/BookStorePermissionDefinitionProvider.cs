using Acme.BookStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.BookStore.Permissions;

public class BookStorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var bookStoreGroup = context.AddGroup(BookStorePermissions.GroupName, L("Permission:BookStore"));

        var booksPermission = bookStoreGroup.AddPermission(BookStorePermissions.Books.Default, L("Permission:Books"));
        bookStoreGroup.AddPermission(BookStorePermissions.Books.Create, L("Permission:Books.Create"));
        bookStoreGroup.AddPermission(BookStorePermissions.Books.Edit, L("Permission:Books.Edit"));
        bookStoreGroup.AddPermission(BookStorePermissions.Books.Delete, L("Permission:Books.Delete"));

        var authorsPermission = bookStoreGroup.AddPermission(BookStorePermissions.Authors.Default, L("Permission:Authors"));
        authorsPermission.AddChild(BookStorePermissions.Authors.Create, L("Permission:Author.Create"));
        authorsPermission.AddChild(BookStorePermissions.Authors.Edit, L("Permission:Author.Edit"));
        authorsPermission.AddChild(BookStorePermissions.Authors.Delete, L("Permission:Author.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookStoreResource>(name);
    }
}
