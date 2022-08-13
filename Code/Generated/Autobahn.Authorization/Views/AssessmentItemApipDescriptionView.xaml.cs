//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentItemApipDescriptionView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
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
