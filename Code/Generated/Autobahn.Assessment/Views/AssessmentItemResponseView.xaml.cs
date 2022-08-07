//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemResponseView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentItemResponseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentItemResponseView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentItemResponseViewModel as the data context for the view
        /// </summary>
        public AssessmentItemResponseView(IAssessmentItemResponseViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
