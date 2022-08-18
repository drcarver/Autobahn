//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefinitionView.cs
//**********************************************************

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialDefinitionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialDefinitionView : ContentPage
    {
        /// <summary>
        /// Inject the ICredentialDefinition View Model as the data context for the view
        /// </summary>
        public CredentialDefinitionView(Interfaces.ICredentialDefinition vm)
        {
            BindingContext  = vm;
        }
    }
}
