//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   FinancialAidAwardView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The FinancialAidAwardView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinancialAidAwardView : ContentPage
    {
        /// <summary>
        /// Inject the IFinancialAidAwardViewModel as the data context for the view
        /// </summary>
        public FinancialAidAwardView(IFinancialAidAwardViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
