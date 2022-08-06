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
        /// Inject the OrganizationServiceViewModel as the data context for the view
        /// </summary>
        public OrganizationServiceView(OrganizationServiceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
