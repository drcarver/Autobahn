//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationIndicatorView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationIndicatorView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationIndicatorView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationIndicatorViewModel as the data context for the view
        /// </summary>
        public OrganizationIndicatorView(IOrganizationIndicatorViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
