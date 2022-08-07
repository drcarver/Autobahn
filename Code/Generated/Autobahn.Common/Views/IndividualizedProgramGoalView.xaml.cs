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
        /// Inject the IIndividualizedProgramGoalViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramGoalView(IIndividualizedProgramGoalViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
