//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySet_RubricCriterionView.cs
//**********************************************************

namespace Autobahn.Competencies.Views
{
     /// <summary>
     /// The CompetencySet_RubricCriterionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetencySet_RubricCriterionView : ContentPage
    {
        /// <summary>
        /// Inject the ICompetencySet_RubricCriterion View Model as the data context for the view
        /// </summary>
        public CompetencySet_RubricCriterionView(Interfaces.ICompetencySet_RubricCriterion vm)
        {
            BindingContext  = vm;
        }
    }
}
