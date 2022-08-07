//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencyDefEducationLevelView.cs
//**********************************************************

using Autobahn.Competencies.ViewModels;

namespace Autobahn.Competencies.Views
{
     /// <summary>
     /// The CompetencyDefEducationLevelView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetencyDefEducationLevelView : ContentPage
    {
        /// <summary>
        /// Inject the ICompetencyDefEducationLevelViewModel as the data context for the view
        /// </summary>
        public CompetencyDefEducationLevelView(ICompetencyDefEducationLevelViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
