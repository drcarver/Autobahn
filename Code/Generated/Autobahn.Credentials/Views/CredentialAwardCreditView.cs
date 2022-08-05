//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialAwardCreditView.cs
//**********************************************************

using Autobahn.Credentials.ViewModels;

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialAwardCreditView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialAwardCreditView : ContentPage
    {
        /// <summary>
        /// Inject the CredentialAwardCreditViewModel as the data context for the view
        /// </summary>
        public CredentialAwardCreditView(CredentialAwardCreditViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}