//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationOperationalStatusView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationOperationalStatusView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationOperationalStatusView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationOperationalStatus View Model as the data context for the view
        /// </summary>
        public OrganizationOperationalStatusView(Interfaces.IOrganizationOperationalStatus vm)
        {
            BindingContext  = vm;
        }
    }
}
