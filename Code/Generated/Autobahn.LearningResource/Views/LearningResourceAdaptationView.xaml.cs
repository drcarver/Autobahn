//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   LearningResourceAdaptationView.cs
//**********************************************************

using Autobahn.LearningResource.ViewModels;

namespace Autobahn.LearningResource.Views
{
     /// <summary>
     /// The LearningResourceAdaptationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearningResourceAdaptationView : ContentPage
    {
        /// <summary>
        /// Inject the ILearningResourceAdaptationViewModel as the data context for the view
        /// </summary>
        public LearningResourceAdaptationView(ILearningResourceAdaptationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
