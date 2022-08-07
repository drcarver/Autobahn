//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentFormSectionView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentFormSectionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentFormSectionView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentFormSectionViewModel as the data context for the view
        /// </summary>
        public AssessmentFormSectionView(IAssessmentFormSectionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
