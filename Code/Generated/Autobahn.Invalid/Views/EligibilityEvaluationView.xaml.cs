//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   EligibilityEvaluationView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
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
