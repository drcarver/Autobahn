//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialAwardEvidenceView.cs
//**********************************************************

using Autobahn.Credentials.ViewModels;

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialAwardEvidenceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialAwardEvidenceView : ContentPage
    {
        /// <summary>
        /// Inject the CredentialAwardEvidenceViewModel as the data context for the view
        /// </summary>
        public CredentialAwardEvidenceView(CredentialAwardEvidenceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
