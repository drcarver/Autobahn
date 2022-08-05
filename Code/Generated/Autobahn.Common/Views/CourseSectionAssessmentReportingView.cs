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
        /// Inject the CourseSectionAssessmentReportingViewModel as the data context for the view
        /// </summary>
        public CourseSectionAssessmentReportingView(CourseSectionAssessmentReportingViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}