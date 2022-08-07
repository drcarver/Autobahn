//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedsProfileScreenEnhancementView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileScreenEnhancementView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentPersonalNeedsProfileScreenEnhancementView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentPersonalNeedsProfileScreenEnhancementViewModel as the data context for the view
        /// </summary>
        public AssessmentPersonalNeedsProfileScreenEnhancementView(IAssessmentPersonalNeedsProfileScreenEnhancementViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
