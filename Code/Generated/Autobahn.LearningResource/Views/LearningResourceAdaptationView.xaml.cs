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
        /// Inject the LearningResourceAdaptationViewModel as the data context for the view
        /// </summary>
        public LearningResourceAdaptationView(LearningResourceAdaptationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
