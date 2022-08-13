//**********************************************************
//* DomainName: Common Models
//* FileName:   Person_AssessmentPersonalNeedsProfileView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The Person_AssessmentPersonalNeedsProfileView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Person_AssessmentPersonalNeedsProfileView : ContentPage
    {
        /// <summary>
        /// Inject the IPerson_AssessmentPersonalNeedsProfile View Model as the data context for the view
        /// </summary>
        public Person_AssessmentPersonalNeedsProfileView(Interfaces.IPerson_AssessmentPersonalNeedsProfile vm)
        {
            BindingContext  = vm;
        }
    }
}
