//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefCriteriaView.cs
//**********************************************************

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialDefCriteriaView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialDefCriteriaView : ContentPage
    {
        /// <summary>
        /// Inject the ICredentialDefCriteria View Model as the data context for the view
        /// </summary>
        public CredentialDefCriteriaView(Interfaces.ICredentialDefCriteria vm)
        {
            BindingContext  = vm;
        }
    }
}
