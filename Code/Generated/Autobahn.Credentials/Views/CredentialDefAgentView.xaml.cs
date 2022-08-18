//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefAgentView.cs
//**********************************************************

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialDefAgentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialDefAgentView : ContentPage
    {
        /// <summary>
        /// Inject the ICredentialDefAgent View Model as the data context for the view
        /// </summary>
        public CredentialDefAgentView(Interfaces.ICredentialDefAgent vm)
        {
            BindingContext  = vm;
        }
    }
}
