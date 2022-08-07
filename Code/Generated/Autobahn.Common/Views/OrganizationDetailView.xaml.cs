//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationDetailView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationDetailView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationDetailView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationDetailViewModel as the data context for the view
        /// </summary>
        public OrganizationDetailView(IOrganizationDetailViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
