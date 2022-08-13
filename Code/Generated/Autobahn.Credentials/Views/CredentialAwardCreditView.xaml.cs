//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardCreditView.cs
//**********************************************************

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialAwardCreditView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialAwardCreditView : ContentPage
    {
        /// <summary>
        /// Inject the ICredentialAwardCredit View Model as the data context for the view
        /// </summary>
        public CredentialAwardCreditView(Interfaces.ICredentialAwardCredit vm)
        {
            BindingContext  = vm;
        }
    }
}
