//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencyDefAssociationView.cs
//**********************************************************

using Autobahn.Competencies.ViewModels;

namespace Autobahn.Competencies.Views
{
     /// <summary>
     /// The CompetencyDefAssociationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetencyDefAssociationView : ContentPage
    {
        /// <summary>
        /// Inject the ICompetencyDefAssociationViewModel as the data context for the view
        /// </summary>
        public CompetencyDefAssociationView(ICompetencyDefAssociationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
