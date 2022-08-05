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
        /// Inject the AssessmentNeedApipDisplayViewModel as the data context for the view
        /// </summary>
        public AssessmentNeedApipDisplayView(AssessmentNeedApipDisplayViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
