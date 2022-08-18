//**********************************************************
//* DomainName: Assessments
//* FileName:   GoalPerformanceView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The GoalPerformanceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GoalPerformanceView : ContentPage
    {
        /// <summary>
        /// Inject the IGoalPerformance View Model as the data context for the view
        /// </summary>
        public GoalPerformanceView(Interfaces.IGoalPerformance vm)
        {
            BindingContext  = vm;
        }
    }
}
