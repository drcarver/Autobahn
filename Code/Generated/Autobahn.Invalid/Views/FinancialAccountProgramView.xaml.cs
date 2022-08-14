//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   FinancialAccountProgramView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The FinancialAccountProgramView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinancialAccountProgramView : ContentPage
    {
        /// <summary>
        /// Inject the IFinancialAccountProgram View Model as the data context for the view
        /// </summary>
        public FinancialAccountProgramView(Interfaces.IFinancialAccountProgram vm)
        {
            BindingContext  = vm;
        }
    }
}
