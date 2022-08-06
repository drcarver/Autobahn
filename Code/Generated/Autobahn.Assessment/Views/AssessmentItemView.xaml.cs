//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentItemView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentItemView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentItemViewModel as the data context for the view
        /// </summary>
        public AssessmentItemView(AssessmentItemViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
