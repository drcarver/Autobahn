//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   CompetencyDefinitionView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The CompetencyDefinitionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetencyDefinitionView : ContentPage
    {
        /// <summary>
        /// Inject the ICompetencyDefinition View Model as the data context for the view
        /// </summary>
        public CompetencyDefinitionView(Interfaces.ICompetencyDefinition vm)
        {
            BindingContext  = vm;
        }
    }
}
