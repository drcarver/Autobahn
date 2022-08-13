//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationWebsiteView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationWebsiteView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationWebsiteView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationWebsite View Model as the data context for the view
        /// </summary>
        public OrganizationWebsiteView(Interfaces.IOrganizationWebsite vm)
        {
            BindingContext  = vm;
        }
    }
}
