//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationFinancialView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationFinancialView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationFinancialView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationFinancialViewModel as the data context for the view
        /// </summary>
        public OrganizationFinancialView(IOrganizationFinancialViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
