//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentNeedApipDisplayView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentNeedApipDisplayView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentNeedApipDisplayView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentNeedApipDisplay View Model as the data context for the view
        /// </summary>
        public AssessmentNeedApipDisplayView(Interfaces.IAssessmentNeedApipDisplay vm)
        {
            BindingContext  = vm;
        }
    }
}
