//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentRegistrationView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentRegistrationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentRegistrationView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentRegistrationViewModel as the data context for the view
        /// </summary>
        public AssessmentRegistrationView(IAssessmentRegistrationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
