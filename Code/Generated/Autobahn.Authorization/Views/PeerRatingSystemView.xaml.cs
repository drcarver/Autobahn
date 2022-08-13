//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   PeerRatingSystemView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The PeerRatingSystemView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeerRatingSystemView : ContentPage
    {
        /// <summary>
        /// Inject the IPeerRatingSystem View Model as the data context for the view
        /// </summary>
        public PeerRatingSystemView(Interfaces.IPeerRatingSystem vm)
        {
            BindingContext  = vm;
        }
    }
}
