//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialDefAgentCredentialView.cs
//**********************************************************

using Autobahn.Credentials.ViewModels;

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialDefAgentCredentialView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialDefAgentCredentialView : ContentPage
    {
        /// <summary>
        /// Inject the ICredentialDefAgentCredentialViewModel as the data context for the view
        /// </summary>
        public CredentialDefAgentCredentialView(ICredentialDefAgentCredentialViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
