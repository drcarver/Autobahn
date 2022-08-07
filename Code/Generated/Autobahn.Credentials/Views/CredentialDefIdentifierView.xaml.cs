//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialDefIdentifierView.cs
//**********************************************************

using Autobahn.Credentials.ViewModels;

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialDefIdentifierView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialDefIdentifierView : ContentPage
    {
        /// <summary>
        /// Inject the ICredentialDefIdentifierViewModel as the data context for the view
        /// </summary>
        public CredentialDefIdentifierView(ICredentialDefIdentifierViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
