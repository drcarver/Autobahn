//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPopulationServedView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationPopulationServedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationPopulationServedView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationPopulationServed View Model as the data context for the view
        /// </summary>
        public OrganizationPopulationServedView(Interfaces.IOrganizationPopulationServed vm)
        {
            BindingContext  = vm;
        }
    }
}
