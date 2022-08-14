//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IDEAEligibilityEvaluationCategoryView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The IDEAEligibilityEvaluationCategoryView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IDEAEligibilityEvaluationCategoryView : ContentPage
    {
        /// <summary>
        /// Inject the IIDEAEligibilityEvaluationCategory View Model as the data context for the view
        /// </summary>
        public IDEAEligibilityEvaluationCategoryView(Interfaces.IIDEAEligibilityEvaluationCategory vm)
        {
            BindingContext  = vm;
        }
    }
}
