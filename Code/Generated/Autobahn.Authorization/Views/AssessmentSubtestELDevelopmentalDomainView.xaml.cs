//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentSubtestELDevelopmentalDomainView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentSubtestELDevelopmentalDomainView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentSubtestELDevelopmentalDomainView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentSubtestELDevelopmentalDomain View Model as the data context for the view
        /// </summary>
        public AssessmentSubtestELDevelopmentalDomainView(Interfaces.IAssessmentSubtestELDevelopmentalDomain vm)
        {
            BindingContext  = vm;
        }
    }
}
