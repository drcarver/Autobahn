//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormAssessmentFormSectionView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentFormAssessmentFormSectionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentFormAssessmentFormSectionView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentFormAssessmentFormSection View Model as the data context for the view
        /// </summary>
        public AssessmentFormAssessmentFormSectionView(Interfaces.IAssessmentFormAssessmentFormSection vm)
        {
            BindingContext  = vm;
        }
    }
}
