//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentELDevelopmentalDomainView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentELDevelopmentalDomainView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentELDevelopmentalDomainView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentELDevelopmentalDomain View Model as the data context for the view
        /// </summary>
        public AssessmentELDevelopmentalDomainView(Interfaces.IAssessmentELDevelopmentalDomain vm)
        {
            BindingContext  = vm;
        }
    }
}
