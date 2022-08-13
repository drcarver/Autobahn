//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationAccreditationView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationAccreditationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationAccreditationView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationAccreditation View Model as the data context for the view
        /// </summary>
        public OrganizationAccreditationView(Interfaces.IOrganizationAccreditation vm)
        {
            BindingContext  = vm;
        }
    }
}
