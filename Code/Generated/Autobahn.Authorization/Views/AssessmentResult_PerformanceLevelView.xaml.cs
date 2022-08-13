//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentResult_PerformanceLevelView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentResult_PerformanceLevelView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentResult_PerformanceLevelView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentResult_PerformanceLevel View Model as the data context for the view
        /// </summary>
        public AssessmentResult_PerformanceLevelView(Interfaces.IAssessmentResult_PerformanceLevel vm)
        {
            BindingContext  = vm;
        }
    }
}
