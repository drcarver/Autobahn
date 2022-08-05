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
        /// Inject the CredentialIssuerViewModel as the data context for the view
        /// </summary>
        public CredentialIssuerView(CredentialIssuerViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
