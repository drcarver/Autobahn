//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   AutobahnElementView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
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
