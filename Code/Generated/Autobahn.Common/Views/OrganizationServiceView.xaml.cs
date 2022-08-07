//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationServiceView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationServiceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationServiceView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationServiceViewModel as the data context for the view
        /// </summary>
        public OrganizationServiceView(IOrganizationServiceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
