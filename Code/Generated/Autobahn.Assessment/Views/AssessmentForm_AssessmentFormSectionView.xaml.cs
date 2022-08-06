//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentForm_AssessmentFormSectionView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentForm_AssessmentFormSectionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentForm_AssessmentFormSectionView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentForm_AssessmentFormSectionViewModel as the data context for the view
        /// </summary>
        public AssessmentForm_AssessmentFormSectionView(AssessmentForm_AssessmentFormSectionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
