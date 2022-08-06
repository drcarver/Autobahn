//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSubtest_CompetencyDefinitionView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentSubtest_CompetencyDefinitionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentSubtest_CompetencyDefinitionView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentSubtest_CompetencyDefinitionViewModel as the data context for the view
        /// </summary>
        public AssessmentSubtest_CompetencyDefinitionView(AssessmentSubtest_CompetencyDefinitionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
