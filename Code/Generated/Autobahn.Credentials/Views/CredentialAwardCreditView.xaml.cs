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
        /// Inject the ICredentialAwardCreditViewModel as the data context for the view
        /// </summary>
        public CredentialAwardCreditView(ICredentialAwardCreditViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
