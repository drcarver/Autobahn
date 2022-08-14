//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentFormView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentFormView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentForm View Model as the data context for the view
        /// </summary>
        public AssessmentFormView(Interfaces.IAssessmentForm vm)
        {
            BindingContext  = vm;
        }
    }
}
