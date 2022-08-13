//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardView.cs
//**********************************************************

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialAwardView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialAwardView : ContentPage
    {
        /// <summary>
        /// Inject the ICredentialAward View Model as the data context for the view
        /// </summary>
        public CredentialAwardView(Interfaces.ICredentialAward vm)
        {
            BindingContext  = vm;
        }
    }
}
