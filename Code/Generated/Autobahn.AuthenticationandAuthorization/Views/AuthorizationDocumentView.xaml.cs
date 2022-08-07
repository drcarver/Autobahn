//**********************************************************
//* DomainName: Autobahn.AuthenticationandAuthorization
//* FileName:   AuthorizationDocumentView.cs
//**********************************************************

using Autobahn.AuthenticationandAuthorization.ViewModels;

namespace Autobahn.AuthenticationandAuthorization.Views
{
     /// <summary>
     /// The AuthorizationDocumentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthorizationDocumentView : ContentPage
    {
        /// <summary>
        /// Inject the IAuthorizationDocumentViewModel as the data context for the view
        /// </summary>
        public AuthorizationDocumentView(IAuthorizationDocumentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
