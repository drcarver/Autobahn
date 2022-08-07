//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPopulationServedView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationPopulationServedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationPopulationServedView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationPopulationServedViewModel as the data context for the view
        /// </summary>
        public OrganizationPopulationServedView(IOrganizationPopulationServedViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
