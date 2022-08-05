//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IDEAEligibilityEvaluationCategoryView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IDEAEligibilityEvaluationCategoryView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IDEAEligibilityEvaluationCategoryView : ContentPage
    {
        /// <summary>
        /// Inject the IDEAEligibilityEvaluationCategoryViewModel as the data context for the view
        /// </summary>
        public IDEAEligibilityEvaluationCategoryView(IDEAEligibilityEvaluationCategoryViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
