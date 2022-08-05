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
        /// Inject the AssessmentPersonalNeedLanguageLearnerViewModel as the data context for the view
        /// </summary>
        public AssessmentPersonalNeedLanguageLearnerView(AssessmentPersonalNeedLanguageLearnerViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
