//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   Assessment_AssessmentAdministrationView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The Assessment_AssessmentAdministrationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Assessment_AssessmentAdministrationView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessment_AssessmentAdministrationViewModel as the data context for the view
        /// </summary>
        public Assessment_AssessmentAdministrationView(IAssessment_AssessmentAdministrationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
