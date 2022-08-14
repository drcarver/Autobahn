//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   FinancialAccountView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The FinancialAccountView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinancialAccountView : ContentPage
    {
        /// <summary>
        /// Inject the IFinancialAccount View Model as the data context for the view
        /// </summary>
        public FinancialAccountView(Interfaces.IFinancialAccount vm)
        {
            BindingContext  = vm;
        }
    }
}
