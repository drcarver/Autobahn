//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleApplicationView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationPersonRoleApplicationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationPersonRoleApplicationView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationPersonRoleApplication View Model as the data context for the view
        /// </summary>
        public OrganizationPersonRoleApplicationView(Interfaces.IOrganizationPersonRoleApplication vm)
        {
            BindingContext  = vm;
        }
    }
}
