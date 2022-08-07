//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencyDefinition_CompetencySetView.cs
//**********************************************************

using Autobahn.Competencies.ViewModels;

namespace Autobahn.Competencies.Views
{
     /// <summary>
     /// The CompetencyDefinition_CompetencySetView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetencyDefinition_CompetencySetView : ContentPage
    {
        /// <summary>
        /// Inject the ICompetencyDefinition_CompetencySetViewModel as the data context for the view
        /// </summary>
        public CompetencyDefinition_CompetencySetView(ICompetencyDefinition_CompetencySetViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
