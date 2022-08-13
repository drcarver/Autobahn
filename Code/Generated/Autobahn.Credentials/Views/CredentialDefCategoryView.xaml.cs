//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefCategoryView.cs
//**********************************************************

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialDefCategoryView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialDefCategoryView : ContentPage
    {
        /// <summary>
        /// Inject the ICredentialDefCategory View Model as the data context for the view
        /// </summary>
        public CredentialDefCategoryView(Interfaces.ICredentialDefCategory vm)
        {
            BindingContext  = vm;
        }
    }
}
