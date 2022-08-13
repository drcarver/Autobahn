//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentFormSection_AssessmentItemView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentFormSection_AssessmentItemView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentFormSection_AssessmentItemView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentFormSection_AssessmentItem View Model as the data context for the view
        /// </summary>
        public AssessmentFormSection_AssessmentItemView(Interfaces.IAssessmentFormSection_AssessmentItem vm)
        {
            BindingContext  = vm;
        }
    }
}
