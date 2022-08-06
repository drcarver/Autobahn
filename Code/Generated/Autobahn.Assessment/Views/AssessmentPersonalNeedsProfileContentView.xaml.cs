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
        /// Inject the AssessmentPersonalNeedsProfileContentViewModel as the data context for the view
        /// </summary>
        public AssessmentPersonalNeedsProfileContentView(AssessmentPersonalNeedsProfileContentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
