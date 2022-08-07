//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   LearningResourceMediaFeatureView.cs
//**********************************************************

using Autobahn.LearningResource.ViewModels;

namespace Autobahn.LearningResource.Views
{
     /// <summary>
     /// The LearningResourceMediaFeatureView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearningResourceMediaFeatureView : ContentPage
    {
        /// <summary>
        /// Inject the ILearningResourceMediaFeatureViewModel as the data context for the view
        /// </summary>
        public LearningResourceMediaFeatureView(ILearningResourceMediaFeatureViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
