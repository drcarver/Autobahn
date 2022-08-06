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
        /// Inject the OrganizationIndicatorViewModel as the data context for the view
        /// </summary>
        public OrganizationIndicatorView(OrganizationIndicatorViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
