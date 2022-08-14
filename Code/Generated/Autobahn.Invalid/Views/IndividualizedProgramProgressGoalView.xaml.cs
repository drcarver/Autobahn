//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramProgressGoalView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The IndividualizedProgramProgressGoalView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramProgressGoalView : ContentPage
    {
        /// <summary>
        /// Inject the IIndividualizedProgramProgressGoal View Model as the data context for the view
        /// </summary>
        public IndividualizedProgramProgressGoalView(Interfaces.IIndividualizedProgramProgressGoal vm)
        {
            BindingContext  = vm;
        }
    }
}
