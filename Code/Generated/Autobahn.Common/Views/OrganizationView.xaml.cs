//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganization View Model as the data context for the view
        /// </summary>
        public OrganizationView(Interfaces.IOrganization vm)
        {
            BindingContext  = vm;
        }
    }
}
