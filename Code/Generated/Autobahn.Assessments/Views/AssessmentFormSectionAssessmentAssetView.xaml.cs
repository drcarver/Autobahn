//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionAssessmentAssetView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentFormSectionAssessmentAssetView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentFormSectionAssessmentAssetView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentFormSectionAssessmentAsset View Model as the data context for the view
        /// </summary>
        public AssessmentFormSectionAssessmentAssetView(Interfaces.IAssessmentFormSectionAssessmentAsset vm)
        {
            BindingContext  = vm;
        }
    }
}
