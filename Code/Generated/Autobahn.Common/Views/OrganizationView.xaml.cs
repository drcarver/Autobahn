//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationViewModel as the data context for the view
        /// </summary>
        public OrganizationView(IOrganizationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
