//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AutobahnTableView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AutobahnTableView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AutobahnTableView : ContentPage
    {
        /// <summary>
        /// Inject the IAutobahnTable View Model as the data context for the view
        /// </summary>
        public AutobahnTableView(Interfaces.IAutobahnTable vm)
        {
            BindingContext  = vm;
        }
    }
}
