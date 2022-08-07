//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedLanguageLearnerView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentPersonalNeedLanguageLearnerView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentPersonalNeedLanguageLearnerView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentPersonalNeedLanguageLearnerViewModel as the data context for the view
        /// </summary>
        public AssessmentPersonalNeedLanguageLearnerView(IAssessmentPersonalNeedLanguageLearnerViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
