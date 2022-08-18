//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardEvidenceView.cs
//**********************************************************

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialAwardEvidenceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialAwardEvidenceView : ContentPage
    {
        /// <summary>
        /// Inject the ICredentialAwardEvidence View Model as the data context for the view
        /// </summary>
        public CredentialAwardEvidenceView(Interfaces.ICredentialAwardEvidence vm)
        {
            BindingContext  = vm;
        }
    }
}
