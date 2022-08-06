//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentFinancialAidView.cs
//**********************************************************

using Autobahn.Postsecondary.ViewModels;

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentFinancialAidView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentFinancialAidView : ContentPage
    {
        /// <summary>
        /// Inject the PsStudentFinancialAidViewModel as the data context for the view
        /// </summary>
        public PsStudentFinancialAidView(PsStudentFinancialAidViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
