//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationAccreditationView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationAccreditationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationAccreditationView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationAccreditationViewModel as the data context for the view
        /// </summary>
        public OrganizationAccreditationView(IOrganizationAccreditationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
