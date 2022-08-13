//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   GoalMeasurementView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The GoalMeasurementView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GoalMeasurementView : ContentPage
    {
        /// <summary>
        /// Inject the IGoalMeasurement View Model as the data context for the view
        /// </summary>
        public GoalMeasurementView(Interfaces.IGoalMeasurement vm)
        {
            BindingContext  = vm;
        }
    }
}
