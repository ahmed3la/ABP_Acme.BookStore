using Acme.BookStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.BookStore.Permissions
{
    public class BookStorePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var bookStoreGroup = context.AddGroup(BookStorePermissions.GroupName,L("Permission:BookStore"));
            //Define your own permissions here. Example:
            //myGroup.AddPermission(BookStorePermissions.MyPermission1, L("Permission:MyPermission1"));
            var bookPermission = bookStoreGroup.AddPermission(BookStorePermissions.Books.Default,L("Permission:Books"));
            bookPermission.AddChild(BookStorePermissions.Books.Create, L("Permission:Permission:Books.Create"));
            bookPermission.AddChild(BookStorePermissions.Books.Edit, L("Permission:Permission:Books.Edit"));
            bookPermission.AddChild(BookStorePermissions.Books.Delete, L("Permission:Permission:Books.Delete")); 
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BookStoreResource>(name);
        }
    }
}
