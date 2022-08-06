//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedsProfileControlView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileControlView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentPersonalNeedsProfileControlView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentPersonalNeedsProfileControlViewModel as the data context for the view
        /// </summary>
        public AssessmentPersonalNeedsProfileControlView(AssessmentPersonalNeedsProfileControlViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
