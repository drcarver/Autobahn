//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ApplicationView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The ApplicationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApplicationView : ContentPage
    {
        /// <summary>
        /// Inject the IApplication View Model as the data context for the view
        /// </summary>
        public ApplicationView(Interfaces.IApplication vm)
        {
            BindingContext  = vm;
        }
    }
}
