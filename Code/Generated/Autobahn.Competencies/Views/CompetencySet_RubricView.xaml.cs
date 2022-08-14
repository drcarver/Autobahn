//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySet_RubricView.cs
//**********************************************************

namespace Autobahn.Competencies.Views
{
     /// <summary>
     /// The CompetencySet_RubricView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetencySet_RubricView : ContentPage
    {
        /// <summary>
        /// Inject the ICompetencySet_Rubric View Model as the data context for the view
        /// </summary>
        public CompetencySet_RubricView(Interfaces.ICompetencySet_Rubric vm)
        {
            BindingContext  = vm;
        }
    }
}
