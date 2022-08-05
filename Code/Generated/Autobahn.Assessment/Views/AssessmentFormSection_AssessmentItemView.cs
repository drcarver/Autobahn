//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentFormSection_AssessmentItemView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentFormSection_AssessmentItemView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentFormSection_AssessmentItemView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentFormSection_AssessmentItemViewModel as the data context for the view
        /// </summary>
        public AssessmentFormSection_AssessmentItemView(AssessmentFormSection_AssessmentItemViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}