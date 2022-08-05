//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentFormSection_AssessmentAssetView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentFormSection_AssessmentAssetView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentFormSection_AssessmentAssetView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentFormSection_AssessmentAssetViewModel as the data context for the view
        /// </summary>
        public AssessmentFormSection_AssessmentAssetView(AssessmentFormSection_AssessmentAssetViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}