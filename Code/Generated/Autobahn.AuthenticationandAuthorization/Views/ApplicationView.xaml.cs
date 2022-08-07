//**********************************************************
//* DomainName: Autobahn.AuthenticationandAuthorization
//* FileName:   ApplicationView.cs
//**********************************************************

using Autobahn.AuthenticationandAuthorization.ViewModels;

namespace Autobahn.AuthenticationandAuthorization.Views
{
     /// <summary>
     /// The ApplicationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApplicationView : ContentPage
    {
        /// <summary>
        /// Inject the IApplicationViewModel as the data context for the view
        /// </summary>
        public ApplicationView(IApplicationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
