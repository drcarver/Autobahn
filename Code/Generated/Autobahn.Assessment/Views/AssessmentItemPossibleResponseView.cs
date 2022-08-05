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
        /// Inject the AssessmentItemPossibleResponseViewModel as the data context for the view
        /// </summary>
        public AssessmentItemPossibleResponseView(AssessmentItemPossibleResponseViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
