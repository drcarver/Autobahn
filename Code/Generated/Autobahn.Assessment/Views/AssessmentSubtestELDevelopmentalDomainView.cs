//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSubtestELDevelopmentalDomainView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentSubtestELDevelopmentalDomainView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentSubtestELDevelopmentalDomainView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentSubtestELDevelopmentalDomainViewModel as the data context for the view
        /// </summary>
        public AssessmentSubtestELDevelopmentalDomainView(AssessmentSubtestELDevelopmentalDomainViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
