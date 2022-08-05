//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPerformanceLevelView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentPerformanceLevelView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentPerformanceLevelView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentPerformanceLevelViewModel as the data context for the view
        /// </summary>
        public AssessmentPerformanceLevelView(AssessmentPerformanceLevelViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}