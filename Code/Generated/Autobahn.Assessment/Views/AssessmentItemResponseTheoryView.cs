//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemResponseTheoryView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentItemResponseTheoryView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentItemResponseTheoryView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentItemResponseTheoryViewModel as the data context for the view
        /// </summary>
        public AssessmentItemResponseTheoryView(AssessmentItemResponseTheoryViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
