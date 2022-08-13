//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessment View Model as the data context for the view
        /// </summary>
        public AssessmentView(Interfaces.IAssessment vm)
        {
            BindingContext  = vm;
        }
    }
}
