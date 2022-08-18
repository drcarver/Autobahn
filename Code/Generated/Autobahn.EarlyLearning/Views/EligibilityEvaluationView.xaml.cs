//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EligibilityEvaluationView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The EligibilityEvaluationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EligibilityEvaluationView : ContentPage
    {
        /// <summary>
        /// Inject the IEligibilityEvaluation View Model as the data context for the view
        /// </summary>
        public EligibilityEvaluationView(Interfaces.IEligibilityEvaluation vm)
        {
            BindingContext  = vm;
        }
    }
}
