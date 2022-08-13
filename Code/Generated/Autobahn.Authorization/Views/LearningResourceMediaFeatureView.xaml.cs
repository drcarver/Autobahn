//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   LearningResourceMediaFeatureView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The LearningResourceMediaFeatureView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearningResourceMediaFeatureView : ContentPage
    {
        /// <summary>
        /// Inject the ILearningResourceMediaFeature View Model as the data context for the view
        /// </summary>
        public LearningResourceMediaFeatureView(Interfaces.ILearningResourceMediaFeature vm)
        {
            BindingContext  = vm;
        }
    }
}
