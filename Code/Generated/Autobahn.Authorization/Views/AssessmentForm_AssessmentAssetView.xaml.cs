//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentForm_AssessmentAssetView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentForm_AssessmentAssetView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentForm_AssessmentAssetView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentForm_AssessmentAsset View Model as the data context for the view
        /// </summary>
        public AssessmentForm_AssessmentAssetView(Interfaces.IAssessmentForm_AssessmentAsset vm)
        {
            BindingContext  = vm;
        }
    }
}
