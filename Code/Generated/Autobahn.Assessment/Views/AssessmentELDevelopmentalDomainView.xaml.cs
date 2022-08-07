//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentELDevelopmentalDomainView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentELDevelopmentalDomainView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentELDevelopmentalDomainView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentELDevelopmentalDomainViewModel as the data context for the view
        /// </summary>
        public AssessmentELDevelopmentalDomainView(IAssessmentELDevelopmentalDomainViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
