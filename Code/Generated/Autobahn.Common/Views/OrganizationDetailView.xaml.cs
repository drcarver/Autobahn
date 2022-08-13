//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationDetailView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationDetailView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationDetailView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationDetail View Model as the data context for the view
        /// </summary>
        public OrganizationDetailView(Interfaces.IOrganizationDetail vm)
        {
            BindingContext  = vm;
        }
    }
}
