//**********************************************************
//* DomainName: Assessments
//* FileName:   RubricCriterionLevelView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The RubricCriterionLevelView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RubricCriterionLevelView : ContentPage
    {
        /// <summary>
        /// Inject the IRubricCriterionLevel View Model as the data context for the view
        /// </summary>
        public RubricCriterionLevelView(Interfaces.IRubricCriterionLevel vm)
        {
            BindingContext  = vm;
        }
    }
}