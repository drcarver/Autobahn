//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationLocationView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationLocationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationLocationView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationLocation View Model as the data context for the view
        /// </summary>
        public OrganizationLocationView(Interfaces.IOrganizationLocation vm)
        {
            BindingContext  = vm;
        }
    }
}
