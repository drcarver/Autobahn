//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileControlView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileControlView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentPersonalNeedsProfileControlView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentPersonalNeedsProfileControl View Model as the data context for the view
        /// </summary>
        public AssessmentPersonalNeedsProfileControlView(Interfaces.IAssessmentPersonalNeedsProfileControl vm)
        {
            BindingContext  = vm;
        }
    }
}