//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceAdaptationView.cs
//**********************************************************

namespace Autobahn.LearningResources.Views
{
     /// <summary>
     /// The LearningResourceAdaptationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearningResourceAdaptationView : ContentPage
    {
        /// <summary>
        /// Inject the ILearningResourceAdaptation View Model as the data context for the view
        /// </summary>
        public LearningResourceAdaptationView(Interfaces.ILearningResourceAdaptation vm)
        {
            BindingContext  = vm;
        }
    }
}
