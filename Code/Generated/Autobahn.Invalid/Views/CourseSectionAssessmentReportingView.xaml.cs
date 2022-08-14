//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CourseSectionAssessmentReportingView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The CourseSectionAssessmentReportingView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseSectionAssessmentReportingView : ContentPage
    {
        /// <summary>
        /// Inject the ICourseSectionAssessmentReporting View Model as the data context for the view
        /// </summary>
        public CourseSectionAssessmentReportingView(Interfaces.ICourseSectionAssessmentReporting vm)
        {
            BindingContext  = vm;
        }
    }
}
