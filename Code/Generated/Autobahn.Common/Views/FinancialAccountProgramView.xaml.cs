//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   FinancialAccountProgramView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The FinancialAccountProgramView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinancialAccountProgramView : ContentPage
    {
        /// <summary>
        /// Inject the IFinancialAccountProgramViewModel as the data context for the view
        /// </summary>
        public FinancialAccountProgramView(IFinancialAccountProgramViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
