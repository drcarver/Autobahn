//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramProgressGoalView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IndividualizedProgramProgressGoalView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramProgressGoalView : ContentPage
    {
        /// <summary>
        /// Inject the IndividualizedProgramProgressGoalViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramProgressGoalView(IndividualizedProgramProgressGoalViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
