//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentFormView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentFormView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentFormView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentFormViewModel as the data context for the view
        /// </summary>
        public AssessmentFormView(AssessmentFormViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
