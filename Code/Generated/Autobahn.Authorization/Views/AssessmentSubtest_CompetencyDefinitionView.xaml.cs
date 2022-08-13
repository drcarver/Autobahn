//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentSubtest_CompetencyDefinitionView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentSubtest_CompetencyDefinitionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentSubtest_CompetencyDefinitionView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentSubtest_CompetencyDefinition View Model as the data context for the view
        /// </summary>
        public AssessmentSubtest_CompetencyDefinitionView(Interfaces.IAssessmentSubtest_CompetencyDefinition vm)
        {
            BindingContext  = vm;
        }
    }
}
