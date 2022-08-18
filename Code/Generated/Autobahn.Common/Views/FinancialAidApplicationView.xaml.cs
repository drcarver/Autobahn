//**********************************************************
//* DomainName: Common Models
//* FileName:   FinancialAidApplicationView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The FinancialAidApplicationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinancialAidApplicationView : ContentPage
    {
        /// <summary>
        /// Inject the IFinancialAidApplication View Model as the data context for the view
        /// </summary>
        public FinancialAidApplicationView(Interfaces.IFinancialAidApplication vm)
        {
            BindingContext  = vm;
        }
    }
}
