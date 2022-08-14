//**********************************************************
//* DomainName: Assessments
//* FileName:   GoalView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The GoalView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GoalView : ContentPage
    {
        /// <summary>
        /// Inject the IGoal View Model as the data context for the view
        /// </summary>
        public GoalView(Interfaces.IGoal vm)
        {
            BindingContext  = vm;
        }
    }
}
