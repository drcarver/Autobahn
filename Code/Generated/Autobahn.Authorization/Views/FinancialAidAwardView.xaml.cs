//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   FinancialAidAwardView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The FinancialAidAwardView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinancialAidAwardView : ContentPage
    {
        /// <summary>
        /// Inject the IFinancialAidAward View Model as the data context for the view
        /// </summary>
        public FinancialAidAwardView(Interfaces.IFinancialAidAward vm)
        {
            BindingContext  = vm;
        }
    }
}
