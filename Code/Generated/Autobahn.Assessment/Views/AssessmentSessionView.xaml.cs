//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSessionView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentSessionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentSessionView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentSessionViewModel as the data context for the view
        /// </summary>
        public AssessmentSessionView(IAssessmentSessionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
