//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentPersonalNeedsProfileContentView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileContentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentPersonalNeedsProfileContentView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentPersonalNeedsProfileContent View Model as the data context for the view
        /// </summary>
        public AssessmentPersonalNeedsProfileContentView(Interfaces.IAssessmentPersonalNeedsProfileContent vm)
        {
            BindingContext  = vm;
        }
    }
}
