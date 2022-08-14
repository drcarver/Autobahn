//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormAssessmentAssetView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentFormAssessmentAssetView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentFormAssessmentAssetView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentFormAssessmentAsset View Model as the data context for the view
        /// </summary>
        public AssessmentFormAssessmentAssetView(Interfaces.IAssessmentFormAssessmentAsset vm)
        {
            BindingContext  = vm;
        }
    }
}
