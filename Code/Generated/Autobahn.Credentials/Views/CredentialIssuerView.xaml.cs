//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialIssuerView.cs
//**********************************************************

using Autobahn.Credentials.ViewModels;

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialIssuerView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialIssuerView : ContentPage
    {
        /// <summary>
        /// Inject the ICredentialIssuerViewModel as the data context for the view
        /// </summary>
        public CredentialIssuerView(ICredentialIssuerViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
