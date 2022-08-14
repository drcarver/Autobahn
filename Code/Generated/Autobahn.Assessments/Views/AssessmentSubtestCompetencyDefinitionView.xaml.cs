//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestCompetencyDefinitionView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentSubtestCompetencyDefinitionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentSubtestCompetencyDefinitionView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentSubtestCompetencyDefinition View Model as the data context for the view
        /// </summary>
        public AssessmentSubtestCompetencyDefinitionView(Interfaces.IAssessmentSubtestCompetencyDefinition vm)
        {
            BindingContext  = vm;
        }
    }
}
