//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   GoalMeasurementView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The GoalMeasurementView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GoalMeasurementView : ContentPage
    {
        /// <summary>
        /// Inject the IGoalMeasurementViewModel as the data context for the view
        /// </summary>
        public GoalMeasurementView(IGoalMeasurementViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
