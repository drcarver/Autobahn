//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   Person_AssessmentPersonalNeedsProfileView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The Person_AssessmentPersonalNeedsProfileView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Person_AssessmentPersonalNeedsProfileView : ContentPage
    {
        /// <summary>
        /// Inject the IPerson_AssessmentPersonalNeedsProfileViewModel as the data context for the view
        /// </summary>
        public Person_AssessmentPersonalNeedsProfileView(IPerson_AssessmentPersonalNeedsProfileViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
