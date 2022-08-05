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
        /// Inject the AssessmentPersonalNeedsProfileScreenEnhancementViewModel as the data context for the view
        /// </summary>
        public AssessmentPersonalNeedsProfileScreenEnhancementView(AssessmentPersonalNeedsProfileScreenEnhancementViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
