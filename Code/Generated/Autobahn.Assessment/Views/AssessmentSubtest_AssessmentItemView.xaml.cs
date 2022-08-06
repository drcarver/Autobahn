//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSubtest_AssessmentItemView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentSubtest_AssessmentItemView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentSubtest_AssessmentItemView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentSubtest_AssessmentItemViewModel as the data context for the view
        /// </summary>
        public AssessmentSubtest_AssessmentItemView(AssessmentSubtest_AssessmentItemViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
