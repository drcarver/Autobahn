//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramEligibilityEvaluationView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IndividualizedProgramEligibilityEvaluationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramEligibilityEvaluationView : ContentPage
    {
        /// <summary>
        /// Inject the IIndividualizedProgramEligibilityEvaluation View Model as the data context for the view
        /// </summary>
        public IndividualizedProgramEligibilityEvaluationView(Interfaces.IIndividualizedProgramEligibilityEvaluation vm)
        {
            BindingContext  = vm;
        }
    }
}
