//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   AutobahnView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The AutobahnView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AutobahnView : ContentPage
    {
        /// <summary>
        /// Inject the IAutobahn View Model as the data context for the view
        /// </summary>
        public AutobahnView(Interfaces.IAutobahn vm)
        {
            BindingContext  = vm;
        }
    }
}
