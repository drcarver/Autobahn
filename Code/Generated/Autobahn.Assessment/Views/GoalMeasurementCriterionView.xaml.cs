//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   GoalMeasurementCriterionView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The GoalMeasurementCriterionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GoalMeasurementCriterionView : ContentPage
    {
        /// <summary>
        /// Inject the GoalMeasurementCriterionViewModel as the data context for the view
        /// </summary>
        public GoalMeasurementCriterionView(GoalMeasurementCriterionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
