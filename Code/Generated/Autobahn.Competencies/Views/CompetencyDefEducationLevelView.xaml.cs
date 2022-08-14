//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefEducationLevelView.cs
//**********************************************************

namespace Autobahn.Competencies.Views
{
     /// <summary>
     /// The CompetencyDefEducationLevelView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetencyDefEducationLevelView : ContentPage
    {
        /// <summary>
        /// Inject the ICompetencyDefEducationLevel View Model as the data context for the view
        /// </summary>
        public CompetencyDefEducationLevelView(Interfaces.ICompetencyDefEducationLevel vm)
        {
            BindingContext  = vm;
        }
    }
}
