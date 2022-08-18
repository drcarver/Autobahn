//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentFinancialAidView.cs
//**********************************************************

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentFinancialAidView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentFinancialAidView : ContentPage
    {
        /// <summary>
        /// Inject the IPsStudentFinancialAid View Model as the data context for the view
        /// </summary>
        public PsStudentFinancialAidView(Interfaces.IPsStudentFinancialAid vm)
        {
            BindingContext  = vm;
        }
    }
}
