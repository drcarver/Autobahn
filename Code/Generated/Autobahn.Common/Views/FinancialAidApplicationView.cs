//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   FinancialAidApplicationView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The FinancialAidApplicationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinancialAidApplicationView : ContentPage
    {
        /// <summary>
        /// Inject the FinancialAidApplicationViewModel as the data context for the view
        /// </summary>
        public FinancialAidApplicationView(FinancialAidApplicationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}