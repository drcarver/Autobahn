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
        /// Inject the AssessmentItemResponseViewModel as the data context for the view
        /// </summary>
        public AssessmentItemResponseView(AssessmentItemResponseViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
