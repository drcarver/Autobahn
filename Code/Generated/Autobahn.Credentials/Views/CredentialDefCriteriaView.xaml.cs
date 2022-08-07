//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialDefCriteriaView.cs
//**********************************************************

using Autobahn.Credentials.ViewModels;

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialDefCriteriaView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialDefCriteriaView : ContentPage
    {
        /// <summary>
        /// Inject the ICredentialDefCriteriaViewModel as the data context for the view
        /// </summary>
        public CredentialDefCriteriaView(ICredentialDefCriteriaViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
