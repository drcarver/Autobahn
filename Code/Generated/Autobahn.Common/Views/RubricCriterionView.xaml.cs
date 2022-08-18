//**********************************************************
//* DomainName: Common Models
//* FileName:   RubricCriterionView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The RubricCriterionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RubricCriterionView : ContentPage
    {
        /// <summary>
        /// Inject the IRubricCriterion View Model as the data context for the view
        /// </summary>
        public RubricCriterionView(Interfaces.IRubricCriterion vm)
        {
            BindingContext  = vm;
        }
    }
}
