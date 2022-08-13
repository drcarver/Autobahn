//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentItemView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentItemView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentItemView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentItem View Model as the data context for the view
        /// </summary>
        public AssessmentItemView(Interfaces.IAssessmentItem vm)
        {
            BindingContext  = vm;
        }
    }
}
