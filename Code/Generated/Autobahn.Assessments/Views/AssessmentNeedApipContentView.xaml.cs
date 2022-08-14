//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedApipContentView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentNeedApipContentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentNeedApipContentView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentNeedApipContent View Model as the data context for the view
        /// </summary>
        public AssessmentNeedApipContentView(Interfaces.IAssessmentNeedApipContent vm)
        {
            BindingContext  = vm;
        }
    }
}
