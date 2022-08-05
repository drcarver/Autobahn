//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencySetView.cs
//**********************************************************

using Autobahn.Competencies.ViewModels;

namespace Autobahn.Competencies.Views
{
     /// <summary>
     /// The CompetencySetView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetencySetView : ContentPage
    {
        /// <summary>
        /// Inject the CompetencySetViewModel as the data context for the view
        /// </summary>
        public CompetencySetView(CompetencySetViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
