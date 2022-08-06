//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   EligibilityEvaluationView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The EligibilityEvaluationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EligibilityEvaluationView : ContentPage
    {
        /// <summary>
        /// Inject the EligibilityEvaluationViewModel as the data context for the view
        /// </summary>
        public EligibilityEvaluationView(EligibilityEvaluationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
