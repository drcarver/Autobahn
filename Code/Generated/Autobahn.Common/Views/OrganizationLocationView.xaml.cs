//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationLocationView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationLocationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationLocationView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationLocationViewModel as the data context for the view
        /// </summary>
        public OrganizationLocationView(IOrganizationLocationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
