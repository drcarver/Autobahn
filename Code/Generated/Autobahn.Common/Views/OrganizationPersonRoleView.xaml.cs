//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationPersonRoleView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationPersonRoleView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationPersonRole View Model as the data context for the view
        /// </summary>
        public OrganizationPersonRoleView(Interfaces.IOrganizationPersonRole vm)
        {
            BindingContext  = vm;
        }
    }
}
