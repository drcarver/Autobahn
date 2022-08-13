//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialOfferedView.cs
//**********************************************************

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialOfferedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialOfferedView : ContentPage
    {
        /// <summary>
        /// Inject the ICredentialOffered View Model as the data context for the view
        /// </summary>
        public CredentialOfferedView(Interfaces.ICredentialOffered vm)
        {
            BindingContext  = vm;
        }
    }
}
