//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentResultPerformanceLevelView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentResultPerformanceLevelView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentResultPerformanceLevelView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentResultPerformanceLevel View Model as the data context for the view
        /// </summary>
        public AssessmentResultPerformanceLevelView(Interfaces.IAssessmentResultPerformanceLevel vm)
        {
            BindingContext  = vm;
        }
    }
}
