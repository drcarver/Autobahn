//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentNeedApipControlView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentNeedApipControlView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentNeedApipControlView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentNeedApipControlViewModel as the data context for the view
        /// </summary>
        public AssessmentNeedApipControlView(AssessmentNeedApipControlViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
