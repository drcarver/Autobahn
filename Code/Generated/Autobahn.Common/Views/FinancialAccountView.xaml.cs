//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   FinancialAccountView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The FinancialAccountView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinancialAccountView : ContentPage
    {
        /// <summary>
        /// Inject the IFinancialAccountViewModel as the data context for the view
        /// </summary>
        public FinancialAccountView(IFinancialAccountViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
