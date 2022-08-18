//**********************************************************
//* DomainName: Assessments
//* FileName:   GoalMeasurementCriterionView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The GoalMeasurementCriterionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GoalMeasurementCriterionView : ContentPage
    {
        /// <summary>
        /// Inject the IGoalMeasurementCriterion View Model as the data context for the view
        /// </summary>
        public GoalMeasurementCriterionView(Interfaces.IGoalMeasurementCriterion vm)
        {
            BindingContext  = vm;
        }
    }
}
