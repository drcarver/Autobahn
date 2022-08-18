//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefentifierView.cs
//**********************************************************

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialDefentifierView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialDefentifierView : ContentPage
    {
        /// <summary>
        /// Inject the ICredentialDefentifier View Model as the data context for the view
        /// </summary>
        public CredentialDefentifierView(Interfaces.ICredentialDefentifier vm)
        {
            BindingContext  = vm;
        }
    }
}
