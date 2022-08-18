//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthorizationView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AuthorizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthorizationView : ContentPage
    {
        /// <summary>
        /// Inject the IAuthorization View Model as the data context for the view
        /// </summary>
        public AuthorizationView(Interfaces.IAuthorization vm)
        {
            BindingContext  = vm;
        }
    }
}
