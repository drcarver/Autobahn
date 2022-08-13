//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   CompetencyDefAssociationView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The CompetencyDefAssociationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetencyDefAssociationView : ContentPage
    {
        /// <summary>
        /// Inject the ICompetencyDefAssociation View Model as the data context for the view
        /// </summary>
        public CompetencyDefAssociationView(Interfaces.ICompetencyDefAssociation vm)
        {
            BindingContext  = vm;
        }
    }
}