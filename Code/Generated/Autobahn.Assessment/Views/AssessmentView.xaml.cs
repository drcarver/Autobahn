//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentViewModel as the data context for the view
        /// </summary>
        public AssessmentView(IAssessmentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
