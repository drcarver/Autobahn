//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AutobahnElementView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AutobahnElementView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AutobahnElementView : ContentPage
    {
        /// <summary>
        /// Inject the IAutobahnElement View Model as the data context for the view
        /// </summary>
        public AutobahnElementView(Interfaces.IAutobahnElement vm)
        {
            BindingContext  = vm;
        }
    }
}
