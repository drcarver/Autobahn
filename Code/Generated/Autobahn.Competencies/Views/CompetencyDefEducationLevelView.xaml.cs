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
        /// Inject the CompetencyDefEducationLevelViewModel as the data context for the view
        /// </summary>
        public CompetencyDefEducationLevelView(CompetencyDefEducationLevelViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
