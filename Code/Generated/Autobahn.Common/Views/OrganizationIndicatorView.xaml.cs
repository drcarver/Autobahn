//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationIndicatorView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationIndicatorView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationIndicatorView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationIndicator View Model as the data context for the view
        /// </summary>
        public OrganizationIndicatorView(Interfaces.IOrganizationIndicator vm)
        {
            BindingContext  = vm;
        }
    }
}
