//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   LearningResourcePeerRatingView.cs
//**********************************************************

using Autobahn.LearningResource.ViewModels;

namespace Autobahn.LearningResource.Views
{
     /// <summary>
     /// The LearningResourcePeerRatingView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearningResourcePeerRatingView : ContentPage
    {
        /// <summary>
        /// Inject the LearningResourcePeerRatingViewModel as the data context for the view
        /// </summary>
        public LearningResourcePeerRatingView(LearningResourcePeerRatingViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}