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
        /// Inject the CredentialDefIdentifierViewModel as the data context for the view
        /// </summary>
        public CredentialDefIdentifierView(CredentialDefIdentifierViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
