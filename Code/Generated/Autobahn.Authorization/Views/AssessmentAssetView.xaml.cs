//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentAssetView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentAssetView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentAssetView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentAsset View Model as the data context for the view
        /// </summary>
        public AssessmentAssetView(Interfaces.IAssessmentAsset vm)
        {
            BindingContext  = vm;
        }
    }
}
