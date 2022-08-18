//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramGoalView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IndividualizedProgramGoalView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramGoalView : ContentPage
    {
        /// <summary>
        /// Inject the IIndividualizedProgramGoal View Model as the data context for the view
        /// </summary>
        public IndividualizedProgramGoalView(Interfaces.IIndividualizedProgramGoal vm)
        {
            BindingContext  = vm;
        }
    }
}
