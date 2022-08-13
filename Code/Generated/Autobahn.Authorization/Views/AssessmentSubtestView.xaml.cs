//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentSubtestView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentSubtestView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentSubtestView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentSubtest View Model as the data context for the view
        /// </summary>
        public AssessmentSubtestView(Interfaces.IAssessmentSubtest vm)
        {
            BindingContext  = vm;
        }
    }
}
