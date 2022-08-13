//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildOutcomeSummaryView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELChildOutcomeSummaryView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELChildOutcomeSummaryView : ContentPage
    {
        /// <summary>
        /// Inject the IELChildOutcomeSummary View Model as the data context for the view
        /// </summary>
        public ELChildOutcomeSummaryView(Interfaces.IELChildOutcomeSummary vm)
        {
            BindingContext  = vm;
        }
    }
}
