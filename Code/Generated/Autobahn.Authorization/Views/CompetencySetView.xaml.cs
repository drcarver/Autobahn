//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   CompetencySetView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The CompetencySetView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetencySetView : ContentPage
    {
        /// <summary>
        /// Inject the ICompetencySet View Model as the data context for the view
        /// </summary>
        public CompetencySetView(Interfaces.ICompetencySet vm)
        {
            BindingContext  = vm;
        }
    }
}
