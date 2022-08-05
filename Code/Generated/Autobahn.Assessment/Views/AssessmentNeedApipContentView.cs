//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentNeedApipContentView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentNeedApipContentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentNeedApipContentView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentNeedApipContentViewModel as the data context for the view
        /// </summary>
        public AssessmentNeedApipContentView(AssessmentNeedApipContentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
