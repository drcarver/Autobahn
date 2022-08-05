//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   AutobahnView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The AutobahnView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AutobahnView : ContentPage
    {
        /// <summary>
        /// Inject the AutobahnViewModel as the data context for the view
        /// </summary>
        public AutobahnView(AutobahnViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
