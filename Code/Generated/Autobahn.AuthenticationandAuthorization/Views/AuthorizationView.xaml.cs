//**********************************************************
//* DomainName: Autobahn.AuthenticationandAuthorization
//* FileName:   AuthorizationView.cs
//**********************************************************

using Autobahn.AuthenticationandAuthorization.ViewModels;

namespace Autobahn.AuthenticationandAuthorization.Views
{
     /// <summary>
     /// The AuthorizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthorizationView : ContentPage
    {
        /// <summary>
        /// Inject the AuthorizationViewModel as the data context for the view
        /// </summary>
        public AuthorizationView(AuthorizationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
