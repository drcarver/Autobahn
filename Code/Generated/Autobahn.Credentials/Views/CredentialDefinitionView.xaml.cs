//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialDefinitionView.cs
//**********************************************************

using Autobahn.Credentials.ViewModels;

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialDefinitionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialDefinitionView : ContentPage
    {
        /// <summary>
        /// Inject the ICredentialDefinitionViewModel as the data context for the view
        /// </summary>
        public CredentialDefinitionView(ICredentialDefinitionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
