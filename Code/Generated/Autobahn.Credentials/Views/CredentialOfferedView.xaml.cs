//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialOfferedView.cs
//**********************************************************

using Autobahn.Credentials.ViewModels;

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialOfferedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialOfferedView : ContentPage
    {
        /// <summary>
        /// Inject the ICredentialOfferedViewModel as the data context for the view
        /// </summary>
        public CredentialOfferedView(ICredentialOfferedViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
