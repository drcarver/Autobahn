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
        /// Inject the AssessmentAssetViewModel as the data context for the view
        /// </summary>
        public AssessmentAssetView(AssessmentAssetViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
