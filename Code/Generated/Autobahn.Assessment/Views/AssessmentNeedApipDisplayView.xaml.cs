//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentNeedApipDisplayView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentNeedApipDisplayView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentNeedApipDisplayView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentNeedApipDisplayViewModel as the data context for the view
        /// </summary>
        public AssessmentNeedApipDisplayView(IAssessmentNeedApipDisplayViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
