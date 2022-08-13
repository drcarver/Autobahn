//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentItemResponseTheoryView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentItemResponseTheoryView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentItemResponseTheoryView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentItemResponseTheory View Model as the data context for the view
        /// </summary>
        public AssessmentItemResponseTheoryView(Interfaces.IAssessmentItemResponseTheory vm)
        {
            BindingContext  = vm;
        }
    }
}
