//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileDisplayView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileDisplayView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentPersonalNeedsProfileDisplayView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentPersonalNeedsProfileDisplay View Model as the data context for the view
        /// </summary>
        public AssessmentPersonalNeedsProfileDisplayView(Interfaces.IAssessmentPersonalNeedsProfileDisplay vm)
        {
            BindingContext  = vm;
        }
    }
}