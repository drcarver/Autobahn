//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialCriteriaCourseView.cs
//**********************************************************

using Autobahn.Credentials.ViewModels;

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialCriteriaCourseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialCriteriaCourseView : ContentPage
    {
        /// <summary>
        /// Inject the CredentialCriteriaCourseViewModel as the data context for the view
        /// </summary>
        public CredentialCriteriaCourseView(CredentialCriteriaCourseViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
