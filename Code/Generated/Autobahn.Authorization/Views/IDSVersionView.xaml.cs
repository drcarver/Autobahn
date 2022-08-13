//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IDSVersionView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The IDSVersionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IDSVersionView : ContentPage
    {
        /// <summary>
        /// Inject the IIDSVersion View Model as the data context for the view
        /// </summary>
        public IDSVersionView(Interfaces.IIDSVersion vm)
        {
            BindingContext  = vm;
        }
    }
}
