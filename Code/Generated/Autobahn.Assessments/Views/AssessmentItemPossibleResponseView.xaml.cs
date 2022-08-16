//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemPossibleResponseView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentItemPossibleResponseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentItemPossibleResponseView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentItemPossibleResponse View Model as the data context for the view
        /// </summary>
        public AssessmentItemPossibleResponseView(Interfaces.IAssessmentItemPossibleResponse vm)
        {
            BindingContext  = vm;
        }
    }
}