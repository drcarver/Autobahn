//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentResultView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentResultView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentResultView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentResult View Model as the data context for the view
        /// </summary>
        public AssessmentResultView(Interfaces.IAssessmentResult vm)
        {
            BindingContext  = vm;
        }
    }
}
