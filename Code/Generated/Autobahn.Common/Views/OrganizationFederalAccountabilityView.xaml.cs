//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationFederalAccountabilityView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationFederalAccountabilityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationFederalAccountabilityView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationFederalAccountability View Model as the data context for the view
        /// </summary>
        public OrganizationFederalAccountabilityView(Interfaces.IOrganizationFederalAccountability vm)
        {
            BindingContext  = vm;
        }
    }
}
