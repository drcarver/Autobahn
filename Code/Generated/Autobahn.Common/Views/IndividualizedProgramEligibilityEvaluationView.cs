//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramEligibilityEvaluationView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IndividualizedProgramEligibilityEvaluationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramEligibilityEvaluationView : ContentPage
    {
        /// <summary>
        /// Inject the IndividualizedProgramEligibilityEvaluationViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramEligibilityEvaluationView(IndividualizedProgramEligibilityEvaluationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
