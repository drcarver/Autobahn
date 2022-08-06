//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencySet_RubricCriterionView.cs
//**********************************************************

using Autobahn.Competencies.ViewModels;

namespace Autobahn.Competencies.Views
{
     /// <summary>
     /// The CompetencySet_RubricCriterionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetencySet_RubricCriterionView : ContentPage
    {
        /// <summary>
        /// Inject the CompetencySet_RubricCriterionViewModel as the data context for the view
        /// </summary>
        public CompetencySet_RubricCriterionView(CompetencySet_RubricCriterionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
