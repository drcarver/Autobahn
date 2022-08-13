//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationServiceView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationServiceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationServiceView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationService View Model as the data context for the view
        /// </summary>
        public OrganizationServiceView(Interfaces.IOrganizationService vm)
        {
            BindingContext  = vm;
        }
    }
}
