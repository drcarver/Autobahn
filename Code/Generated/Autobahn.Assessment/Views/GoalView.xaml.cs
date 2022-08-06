//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   GoalView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The GoalView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GoalView : ContentPage
    {
        /// <summary>
        /// Inject the GoalViewModel as the data context for the view
        /// </summary>
        public GoalView(GoalViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
