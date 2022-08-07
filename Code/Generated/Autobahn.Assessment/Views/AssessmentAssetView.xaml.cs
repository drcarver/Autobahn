//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentAssetView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentAssetView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentAssetView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentAssetViewModel as the data context for the view
        /// </summary>
        public AssessmentAssetView(IAssessmentAssetViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
