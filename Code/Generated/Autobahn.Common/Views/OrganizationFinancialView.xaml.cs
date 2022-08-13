//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationFinancialView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationFinancialView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationFinancialView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationFinancial View Model as the data context for the view
        /// </summary>
        public OrganizationFinancialView(Interfaces.IOrganizationFinancial vm)
        {
            BindingContext  = vm;
        }
    }
}
