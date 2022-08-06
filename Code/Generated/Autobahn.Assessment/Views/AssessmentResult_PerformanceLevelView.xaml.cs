//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentResult_PerformanceLevelView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentResult_PerformanceLevelView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentResult_PerformanceLevelView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentResult_PerformanceLevelViewModel as the data context for the view
        /// </summary>
        public AssessmentResult_PerformanceLevelView(AssessmentResult_PerformanceLevelViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
