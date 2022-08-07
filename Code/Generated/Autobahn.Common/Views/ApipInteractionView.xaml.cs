//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ApipInteractionView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ApipInteractionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApipInteractionView : ContentPage
    {
        /// <summary>
        /// Inject the IApipInteractionViewModel as the data context for the view
        /// </summary>
        public ApipInteractionView(IApipInteractionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
