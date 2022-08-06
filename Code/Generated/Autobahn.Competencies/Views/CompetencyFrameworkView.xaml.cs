//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencyFrameworkView.cs
//**********************************************************

using Autobahn.Competencies.ViewModels;

namespace Autobahn.Competencies.Views
{
     /// <summary>
     /// The CompetencyFrameworkView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetencyFrameworkView : ContentPage
    {
        /// <summary>
        /// Inject the CompetencyFrameworkViewModel as the data context for the view
        /// </summary>
        public CompetencyFrameworkView(CompetencyFrameworkViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
