//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentPersonalNeedsProfileView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentPersonalNeedsProfileView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentPersonalNeedsProfile View Model as the data context for the view
        /// </summary>
        public AssessmentPersonalNeedsProfileView(Interfaces.IAssessmentPersonalNeedsProfile vm)
        {
            BindingContext  = vm;
        }
    }
}
