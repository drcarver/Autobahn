//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAssessmentPersonalNeedsProfileView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonAssessmentPersonalNeedsProfileView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonAssessmentPersonalNeedsProfileView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonAssessmentPersonalNeedsProfile View Model as the data context for the view
        /// </summary>
        public PersonAssessmentPersonalNeedsProfileView(Interfaces.IPersonAssessmentPersonalNeedsProfile vm)
        {
            BindingContext  = vm;
        }
    }
}
