//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemApipDescriptionView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentItemApipDescriptionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentItemApipDescriptionView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentItemApipDescription View Model as the data context for the view
        /// </summary>
        public AssessmentItemApipDescriptionView(Interfaces.IAssessmentItemApipDescription vm)
        {
            BindingContext  = vm;
        }
    }
}
