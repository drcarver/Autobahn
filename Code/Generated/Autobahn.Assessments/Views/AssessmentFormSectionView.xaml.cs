//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentFormSectionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentFormSectionView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentFormSection View Model as the data context for the view
        /// </summary>
        public AssessmentFormSectionView(Interfaces.IAssessmentFormSection vm)
        {
            BindingContext  = vm;
        }
    }
}
