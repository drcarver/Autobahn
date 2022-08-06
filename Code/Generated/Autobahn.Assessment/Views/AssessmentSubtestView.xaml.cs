//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSubtestView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentSubtestView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentSubtestView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentSubtestViewModel as the data context for the view
        /// </summary>
        public AssessmentSubtestView(AssessmentSubtestViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
