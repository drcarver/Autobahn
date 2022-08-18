//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearnerActivityLearningResourceView.cs
//**********************************************************

namespace Autobahn.LearningResources.Views
{
     /// <summary>
     /// The LearnerActivityLearningResourceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearnerActivityLearningResourceView : ContentPage
    {
        /// <summary>
        /// Inject the ILearnerActivityLearningResource View Model as the data context for the view
        /// </summary>
        public LearnerActivityLearningResourceView(Interfaces.ILearnerActivityLearningResource vm)
        {
            BindingContext  = vm;
        }
    }
}
