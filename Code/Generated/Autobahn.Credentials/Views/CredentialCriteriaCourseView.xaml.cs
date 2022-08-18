//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialCriteriaCourseView.cs
//**********************************************************

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialCriteriaCourseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialCriteriaCourseView : ContentPage
    {
        /// <summary>
        /// Inject the ICredentialCriteriaCourse View Model as the data context for the view
        /// </summary>
        public CredentialCriteriaCourseView(Interfaces.ICredentialCriteriaCourse vm)
        {
            BindingContext  = vm;
        }
    }
}
