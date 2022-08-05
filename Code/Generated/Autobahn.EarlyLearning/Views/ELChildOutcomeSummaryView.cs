//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildOutcomeSummaryView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELChildOutcomeSummaryView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELChildOutcomeSummaryView : ContentPage
    {
        /// <summary>
        /// Inject the ELChildOutcomeSummaryViewModel as the data context for the view
        /// </summary>
        public ELChildOutcomeSummaryView(ELChildOutcomeSummaryViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
