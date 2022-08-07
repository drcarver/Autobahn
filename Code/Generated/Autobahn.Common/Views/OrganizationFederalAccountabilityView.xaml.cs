//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationFederalAccountabilityView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationFederalAccountabilityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationFederalAccountabilityView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationFederalAccountabilityViewModel as the data context for the view
        /// </summary>
        public OrganizationFederalAccountabilityView(IOrganizationFederalAccountabilityViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
