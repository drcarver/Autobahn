//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedsProfileView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentPersonalNeedsProfileView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentPersonalNeedsProfileViewModel as the data context for the view
        /// </summary>
        public AssessmentPersonalNeedsProfileView(IAssessmentPersonalNeedsProfileViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
