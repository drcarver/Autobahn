//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemPossibleResponseView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentItemPossibleResponseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentItemPossibleResponseView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentItemPossibleResponseViewModel as the data context for the view
        /// </summary>
        public AssessmentItemPossibleResponseView(IAssessmentItemPossibleResponseViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
