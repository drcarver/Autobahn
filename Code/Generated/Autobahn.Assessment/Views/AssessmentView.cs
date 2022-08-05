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
        /// Inject the AssessmentViewModel as the data context for the view
        /// </summary>
        public AssessmentView(AssessmentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
