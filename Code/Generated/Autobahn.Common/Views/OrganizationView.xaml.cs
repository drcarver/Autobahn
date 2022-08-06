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
        /// Inject the OrganizationViewModel as the data context for the view
        /// </summary>
        public OrganizationView(OrganizationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
