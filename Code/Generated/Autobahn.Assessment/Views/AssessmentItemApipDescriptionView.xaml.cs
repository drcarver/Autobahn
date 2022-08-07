//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemApipDescriptionView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentItemApipDescriptionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentItemApipDescriptionView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentItemApipDescriptionViewModel as the data context for the view
        /// </summary>
        public AssessmentItemApipDescriptionView(IAssessmentItemApipDescriptionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
