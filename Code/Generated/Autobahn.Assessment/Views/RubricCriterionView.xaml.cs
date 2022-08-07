//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RubricCriterionView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The RubricCriterionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RubricCriterionView : ContentPage
    {
        /// <summary>
        /// Inject the IRubricCriterionViewModel as the data context for the view
        /// </summary>
        public RubricCriterionView(IRubricCriterionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
