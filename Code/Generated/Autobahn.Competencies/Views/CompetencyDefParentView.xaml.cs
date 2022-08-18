//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefParentView.cs
//**********************************************************

namespace Autobahn.Competencies.Views
{
     /// <summary>
     /// The CompetencyDefParentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetencyDefParentView : ContentPage
    {
        /// <summary>
        /// Inject the ICompetencyDefParent View Model as the data context for the view
        /// </summary>
        public CompetencyDefParentView(Interfaces.ICompetencyDefParent vm)
        {
            BindingContext  = vm;
        }
    }
}
