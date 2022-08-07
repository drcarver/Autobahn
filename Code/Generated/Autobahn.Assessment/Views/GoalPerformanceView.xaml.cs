//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   GoalPerformanceView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The GoalPerformanceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GoalPerformanceView : ContentPage
    {
        /// <summary>
        /// Inject the IGoalPerformanceViewModel as the data context for the view
        /// </summary>
        public GoalPerformanceView(IGoalPerformanceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
