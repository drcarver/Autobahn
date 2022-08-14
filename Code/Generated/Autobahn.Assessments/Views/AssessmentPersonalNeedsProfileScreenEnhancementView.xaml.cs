//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileScreenEnhancementView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileScreenEnhancementView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentPersonalNeedsProfileScreenEnhancementView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentPersonalNeedsProfileScreenEnhancement View Model as the data context for the view
        /// </summary>
        public AssessmentPersonalNeedsProfileScreenEnhancementView(Interfaces.IAssessmentPersonalNeedsProfileScreenEnhancement vm)
        {
            BindingContext  = vm;
        }
    }
}
