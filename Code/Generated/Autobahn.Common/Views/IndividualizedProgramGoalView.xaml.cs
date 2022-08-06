//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramGoalView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IndividualizedProgramGoalView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramGoalView : ContentPage
    {
        /// <summary>
        /// Inject the IndividualizedProgramGoalViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramGoalView(IndividualizedProgramGoalViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
