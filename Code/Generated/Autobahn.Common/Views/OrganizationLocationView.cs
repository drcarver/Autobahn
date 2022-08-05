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
        /// Inject the OrganizationLocationViewModel as the data context for the view
        /// </summary>
        public OrganizationLocationView(OrganizationLocationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
