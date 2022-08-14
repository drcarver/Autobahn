//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   AutobahnTableView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
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
