//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationWebsiteView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationWebsiteView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationWebsiteView : ContentPage
    {
        /// <summary>
        /// Inject the OrganizationWebsiteViewModel as the data context for the view
        /// </summary>
        public OrganizationWebsiteView(OrganizationWebsiteViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
