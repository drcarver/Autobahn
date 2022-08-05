//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialAwardView.cs
//**********************************************************

using Autobahn.Credentials.ViewModels;

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialAwardView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialAwardView : ContentPage
    {
        /// <summary>
        /// Inject the CredentialAwardViewModel as the data context for the view
        /// </summary>
        public CredentialAwardView(CredentialAwardViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
