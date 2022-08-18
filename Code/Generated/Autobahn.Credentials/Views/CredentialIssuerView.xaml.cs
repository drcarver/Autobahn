//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialIssuerView.cs
//**********************************************************

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialIssuerView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialIssuerView : ContentPage
    {
        /// <summary>
        /// Inject the ICredentialIssuer View Model as the data context for the view
        /// </summary>
        public CredentialIssuerView(Interfaces.ICredentialIssuer vm)
        {
            BindingContext  = vm;
        }
    }
}
