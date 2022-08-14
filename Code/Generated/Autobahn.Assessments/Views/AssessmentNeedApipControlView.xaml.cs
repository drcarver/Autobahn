//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedApipControlView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentNeedApipControlView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentNeedApipControlView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentNeedApipControl View Model as the data context for the view
        /// </summary>
        public AssessmentNeedApipControlView(Interfaces.IAssessmentNeedApipControl vm)
        {
            BindingContext  = vm;
        }
    }
}
