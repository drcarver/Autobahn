//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   PeerRatingSystemView.cs
//**********************************************************

using Autobahn.LearningResource.ViewModels;

namespace Autobahn.LearningResource.Views
{
     /// <summary>
     /// The PeerRatingSystemView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeerRatingSystemView : ContentPage
    {
        /// <summary>
        /// Inject the PeerRatingSystemViewModel as the data context for the view
        /// </summary>
        public PeerRatingSystemView(PeerRatingSystemViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
