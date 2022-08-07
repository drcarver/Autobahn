//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionAssessmentReportingView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The CourseSectionAssessmentReportingView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseSectionAssessmentReportingView : ContentPage
    {
        /// <summary>
        /// Inject the ICourseSectionAssessmentReportingViewModel as the data context for the view
        /// </summary>
        public CourseSectionAssessmentReportingView(ICourseSectionAssessmentReportingViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
