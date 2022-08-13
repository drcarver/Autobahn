//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentItemApipView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentItemApipView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentItemApipView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentItemApip View Model as the data context for the view
        /// </summary>
        public AssessmentItemApipView(Interfaces.IAssessmentItemApip vm)
        {
            BindingContext  = vm;
        }
    }
}
