//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentNeedScreenEnhancementView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentNeedScreenEnhancementView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentNeedScreenEnhancementView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentNeedScreenEnhancement View Model as the data context for the view
        /// </summary>
        public AssessmentNeedScreenEnhancementView(Interfaces.IAssessmentNeedScreenEnhancement vm)
        {
            BindingContext  = vm;
        }
    }
}
