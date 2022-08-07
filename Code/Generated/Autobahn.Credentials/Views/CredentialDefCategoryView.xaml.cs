//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialDefCategoryView.cs
//**********************************************************

using Autobahn.Credentials.ViewModels;

namespace Autobahn.Credentials.Views
{
     /// <summary>
     /// The CredentialDefCategoryView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CredentialDefCategoryView : ContentPage
    {
        /// <summary>
        /// Inject the ICredentialDefCategoryViewModel as the data context for the view
        /// </summary>
        public CredentialDefCategoryView(ICredentialDefCategoryViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
