//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentAdministrationView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentAdministrationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentAdministrationView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentAdministrationViewModel as the data context for the view
        /// </summary>
        public AssessmentAdministrationView(AssessmentAdministrationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
