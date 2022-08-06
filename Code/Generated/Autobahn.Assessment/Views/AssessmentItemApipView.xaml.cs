//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemApipView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentItemApipView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentItemApipView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentItemApipViewModel as the data context for the view
        /// </summary>
        public AssessmentItemApipView(AssessmentItemApipViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
