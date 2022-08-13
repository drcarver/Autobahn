//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ApipInteractionView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The ApipInteractionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApipInteractionView : ContentPage
    {
        /// <summary>
        /// Inject the IApipInteraction View Model as the data context for the view
        /// </summary>
        public ApipInteractionView(Interfaces.IApipInteraction vm)
        {
            BindingContext  = vm;
        }
    }
}
