//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentLanguageView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentLanguageView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentLanguageView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentLanguage View Model as the data context for the view
        /// </summary>
        public AssessmentLanguageView(Interfaces.IAssessmentLanguage vm)
        {
            BindingContext  = vm;
        }
    }
}
