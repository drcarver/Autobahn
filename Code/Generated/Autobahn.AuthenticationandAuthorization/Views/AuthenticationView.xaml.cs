//**********************************************************
//* DomainName: Autobahn.AuthenticationandAuthorization
//* FileName:   AuthenticationView.cs
//**********************************************************

using Autobahn.AuthenticationandAuthorization.ViewModels;

namespace Autobahn.AuthenticationandAuthorization.Views
{
     /// <summary>
     /// The AuthenticationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthenticationView : ContentPage
    {
        /// <summary>
        /// Inject the IAuthenticationViewModel as the data context for the view
        /// </summary>
        public AuthenticationView(IAuthenticationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
