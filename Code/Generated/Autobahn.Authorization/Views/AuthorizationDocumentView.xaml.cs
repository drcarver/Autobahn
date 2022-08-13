//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthorizationDocumentView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AuthorizationDocumentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthorizationDocumentView : ContentPage
    {
        /// <summary>
        /// Inject the IAuthorizationDocument View Model as the data context for the view
        /// </summary>
        public AuthorizationDocumentView(Interfaces.IAuthorizationDocument vm)
        {
            BindingContext  = vm;
        }
    }
}
