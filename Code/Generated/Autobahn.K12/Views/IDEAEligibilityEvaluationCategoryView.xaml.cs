//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IDEAEligibilityEvaluationCategoryView.cs
//**********************************************************

namespace Autobahn.K12.Views
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
