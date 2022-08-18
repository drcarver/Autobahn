//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyFrameworkView.cs
//**********************************************************

namespace Autobahn.Competencies.Views
{
     /// <summary>
     /// The CompetencyFrameworkView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetencyFrameworkView : ContentPage
    {
        /// <summary>
        /// Inject the ICompetencyFramework View Model as the data context for the view
        /// </summary>
        public CompetencyFrameworkView(Interfaces.ICompetencyFramework vm)
        {
            BindingContext  = vm;
        }
    }
}
