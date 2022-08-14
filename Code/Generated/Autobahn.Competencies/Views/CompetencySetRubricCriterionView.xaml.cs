//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetRubricCriterionView.cs
//**********************************************************

namespace Autobahn.Competencies.Views
{
     /// <summary>
     /// The CompetencySetRubricCriterionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetencySetRubricCriterionView : ContentPage
    {
        /// <summary>
        /// Inject the ICompetencySetRubricCriterion View Model as the data context for the view
        /// </summary>
        public CompetencySetRubricCriterionView(Interfaces.ICompetencySetRubricCriterion vm)
        {
            BindingContext  = vm;
        }
    }
}
