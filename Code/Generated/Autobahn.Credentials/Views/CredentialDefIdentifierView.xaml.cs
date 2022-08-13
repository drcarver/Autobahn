//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefIdentifierView.cs
//**********************************************************

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialDefIdentifierView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialDefIdentifierView : ContentPage
    {
        /// <summary>
        /// Inject the ICredentialDefIdentifier View Model as the data context for the view
        /// </summary>
        public CredentialDefIdentifierView(Interfaces.ICredentialDefIdentifier vm)
        {
            BindingContext  = vm;
        }
    }
}
