//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedsProfileContentView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileContentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentPersonalNeedsProfileContentView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentPersonalNeedsProfileContentViewModel as the data context for the view
        /// </summary>
        public AssessmentPersonalNeedsProfileContentView(IAssessmentPersonalNeedsProfileContentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
