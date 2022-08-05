//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentForm_AssessmentAssetView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentForm_AssessmentAssetView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentForm_AssessmentAssetView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentForm_AssessmentAssetViewModel as the data context for the view
        /// </summary>
        public AssessmentForm_AssessmentAssetView(AssessmentForm_AssessmentAssetViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}