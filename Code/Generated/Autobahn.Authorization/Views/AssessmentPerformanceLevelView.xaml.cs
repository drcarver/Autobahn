//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentPerformanceLevelView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentPerformanceLevelView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentPerformanceLevelView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentPerformanceLevel View Model as the data context for the view
        /// </summary>
        public AssessmentPerformanceLevelView(Interfaces.IAssessmentPerformanceLevel vm)
        {
            BindingContext  = vm;
        }
    }
}
