//**********************************************************
//* DomainName: Competencies
//* FileName:   ChildOfCompetencyDefinitionView.cs
//**********************************************************

namespace Autobahn.Competencies.Views
{
     /// <summary>
     /// The ChildOfCompetencyDefinitionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChildOfCompetencyDefinitionView : ContentPage
    {
        /// <summary>
        /// Inject the IChildOfCompetencyDefinition View Model as the data context for the view
        /// </summary>
        public ChildOfCompetencyDefinitionView(Interfaces.IChildOfCompetencyDefinition vm)
        {
            BindingContext  = vm;
        }
    }
}
