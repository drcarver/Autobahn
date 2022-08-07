//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencyDefinitionView.cs
//**********************************************************

using Autobahn.Competencies.ViewModels;

namespace Autobahn.Competencies.Views
{
     /// <summary>
     /// The CompetencyDefinitionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetencyDefinitionView : ContentPage
    {
        /// <summary>
        /// Inject the ICompetencyDefinitionViewModel as the data context for the view
        /// </summary>
        public CompetencyDefinitionView(ICompetencyDefinitionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
