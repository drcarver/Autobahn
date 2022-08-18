//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefinitionCompetencySetView.cs
//**********************************************************

namespace Autobahn.Competencies.Views
{
     /// <summary>
     /// The CompetencyDefinitionCompetencySetView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetencyDefinitionCompetencySetView : ContentPage
    {
        /// <summary>
        /// Inject the ICompetencyDefinitionCompetencySet View Model as the data context for the view
        /// </summary>
        public CompetencyDefinitionCompetencySetView(Interfaces.ICompetencyDefinitionCompetencySet vm)
        {
            BindingContext  = vm;
        }
    }
}
