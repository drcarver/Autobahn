//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourcePeerRatingView.cs
//**********************************************************

namespace Autobahn.LearningResources.Views
{
     /// <summary>
     /// The LearningResourcePeerRatingView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearningResourcePeerRatingView : ContentPage
    {
        /// <summary>
        /// Inject the ILearningResourcePeerRating View Model as the data context for the view
        /// </summary>
        public LearningResourcePeerRatingView(Interfaces.ILearningResourcePeerRating vm)
        {
            BindingContext  = vm;
        }
    }
}
