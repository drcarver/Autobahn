//**********************************************************
//* DomainName: Assessments
//* FileName:   ChildOfAssessmentSubtestView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The ChildOfAssessmentSubtestView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChildOfAssessmentSubtestView : ContentPage
    {
        /// <summary>
        /// Inject the IChildOfAssessmentSubtest View Model as the data context for the view
        /// </summary>
        public ChildOfAssessmentSubtestView(Interfaces.IChildOfAssessmentSubtest vm)
        {
            BindingContext  = vm;
        }
    }
}
