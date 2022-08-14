//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefinition_CompetencySetView.cs
//**********************************************************

namespace Autobahn.Competencies.Views
{
     /// <summary>
     /// The CompetencyDefinition_CompetencySetView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetencyDefinition_CompetencySetView : ContentPage
    {
        /// <summary>
        /// Inject the ICompetencyDefinition_CompetencySet View Model as the data context for the view
        /// </summary>
        public CompetencyDefinition_CompetencySetView(Interfaces.ICompetencyDefinition_CompetencySet vm)
        {
            BindingContext  = vm;
        }
    }
}
