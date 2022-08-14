//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedLanguageLearnerView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentPersonalNeedLanguageLearnerView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentPersonalNeedLanguageLearnerView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentPersonalNeedLanguageLearner View Model as the data context for the view
        /// </summary>
        public AssessmentPersonalNeedLanguageLearnerView(Interfaces.IAssessmentPersonalNeedLanguageLearner vm)
        {
            BindingContext  = vm;
        }
    }
}
