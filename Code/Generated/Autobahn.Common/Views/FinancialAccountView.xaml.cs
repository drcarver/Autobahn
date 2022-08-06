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
        /// Inject the FinancialAccountViewModel as the data context for the view
        /// </summary>
        public FinancialAccountView(FinancialAccountViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
