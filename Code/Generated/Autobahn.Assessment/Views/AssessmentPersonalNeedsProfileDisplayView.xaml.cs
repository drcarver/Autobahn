//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedsProfileDisplayView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileDisplayView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentPersonalNeedsProfileDisplayView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentPersonalNeedsProfileDisplayViewModel as the data context for the view
        /// </summary>
        public AssessmentPersonalNeedsProfileDisplayView(AssessmentPersonalNeedsProfileDisplayViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
