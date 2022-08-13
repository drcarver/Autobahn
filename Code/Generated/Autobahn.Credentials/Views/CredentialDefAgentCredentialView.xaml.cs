//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefAgentCredentialView.cs
//**********************************************************

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialDefAgentCredentialView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialDefAgentCredentialView : ContentPage
    {
        /// <summary>
        /// Inject the ICredentialDefAgentCredential View Model as the data context for the view
        /// </summary>
        public CredentialDefAgentCredentialView(Interfaces.ICredentialDefAgentCredential vm)
        {
            BindingContext  = vm;
        }
    }
}
