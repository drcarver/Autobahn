//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthenticationView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AuthenticationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthenticationView : ContentPage
    {
        /// <summary>
        /// Inject the IAuthentication View Model as the data context for the view
        /// </summary>
        public AuthenticationView(Interfaces.IAuthentication vm)
        {
            BindingContext  = vm;
        }
    }
}
