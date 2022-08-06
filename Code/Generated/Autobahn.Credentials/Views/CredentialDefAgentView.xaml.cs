//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialDefAgentView.cs
//**********************************************************

using Autobahn.Credentials.ViewModels;

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialDefAgentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialDefAgentView : ContentPage
    {
        /// <summary>
        /// Inject the CredentialDefAgentViewModel as the data context for the view
        /// </summary>
        public CredentialDefAgentView(CredentialDefAgentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
