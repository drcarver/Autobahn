//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AutobahnDomainView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AutobahnDomainView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AutobahnDomainView : ContentPage
    {
        /// <summary>
        /// Inject the IAutobahnDomain View Model as the data context for the view
        /// </summary>
        public AutobahnDomainView(Interfaces.IAutobahnDomain vm)
        {
            BindingContext  = vm;
        }
    }
}
