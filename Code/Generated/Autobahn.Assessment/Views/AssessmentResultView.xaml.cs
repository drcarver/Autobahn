//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentResultView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentResultView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentResultView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentResultViewModel as the data context for the view
        /// </summary>
        public AssessmentResultView(AssessmentResultViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
