//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencySet_RubricView.cs
//**********************************************************

using Autobahn.Competencies.ViewModels;

namespace Autobahn.Competencies.Views
{
     /// <summary>
     /// The CompetencySet_RubricView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetencySet_RubricView : ContentPage
    {
        /// <summary>
        /// Inject the ICompetencySet_RubricViewModel as the data context for the view
        /// </summary>
        public CompetencySet_RubricView(ICompetencySet_RubricViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
