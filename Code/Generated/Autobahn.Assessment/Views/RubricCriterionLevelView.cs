//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RubricCriterionLevelView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The RubricCriterionLevelView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RubricCriterionLevelView : ContentPage
    {
        /// <summary>
        /// Inject the RubricCriterionLevelViewModel as the data context for the view
        /// </summary>
        public RubricCriterionLevelView(RubricCriterionLevelViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
