//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationTelephoneView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationTelephoneView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationTelephoneView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationTelephone View Model as the data context for the view
        /// </summary>
        public OrganizationTelephoneView(Interfaces.IOrganizationTelephone vm)
        {
            BindingContext  = vm;
        }
    }
}
