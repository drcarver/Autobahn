//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetRubricView.cs
//**********************************************************

namespace Autobahn.Competencies.Views
{
     /// <summary>
     /// The CompetencySetRubricView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetencySetRubricView : ContentPage
    {
        /// <summary>
        /// Inject the ICompetencySetRubric View Model as the data context for the view
        /// </summary>
        public CompetencySetRubricView(Interfaces.ICompetencySetRubric vm)
        {
            BindingContext  = vm;
        }
    }
}
