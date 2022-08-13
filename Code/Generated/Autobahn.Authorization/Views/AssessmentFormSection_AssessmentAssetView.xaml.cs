//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentFormSection_AssessmentAssetView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentFormSection_AssessmentAssetView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentFormSection_AssessmentAssetView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentFormSection_AssessmentAsset View Model as the data context for the view
        /// </summary>
        public AssessmentFormSection_AssessmentAssetView(Interfaces.IAssessmentFormSection_AssessmentAsset vm)
        {
            BindingContext  = vm;
        }
    }
}
