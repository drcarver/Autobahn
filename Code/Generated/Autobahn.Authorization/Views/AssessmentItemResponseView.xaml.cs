//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentItemResponseView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentItemResponseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentItemResponseView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentItemResponse View Model as the data context for the view
        /// </summary>
        public AssessmentItemResponseView(Interfaces.IAssessmentItemResponse vm)
        {
            BindingContext  = vm;
        }
    }
}