//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentPersonalNeedScreenReaderView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentPersonalNeedScreenReaderView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentPersonalNeedScreenReaderView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentPersonalNeedScreenReader View Model as the data context for the view
        /// </summary>
        public AssessmentPersonalNeedScreenReaderView(Interfaces.IAssessmentPersonalNeedScreenReader vm)
        {
            BindingContext  = vm;
        }
    }
}
