//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentForm_AssessmentFormSectionView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentForm_AssessmentFormSectionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentForm_AssessmentFormSectionView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentForm_AssessmentFormSection View Model as the data context for the view
        /// </summary>
        public AssessmentForm_AssessmentFormSectionView(Interfaces.IAssessmentForm_AssessmentFormSection vm)
        {
            BindingContext  = vm;
        }
    }
}
