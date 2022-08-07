//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   LearningResourcePhysicalMediaView.cs
//**********************************************************

using Autobahn.LearningResource.ViewModels;

namespace Autobahn.LearningResource.Views
{
     /// <summary>
     /// The LearningResourcePhysicalMediaView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearningResourcePhysicalMediaView : ContentPage
    {
        /// <summary>
        /// Inject the ILearningResourcePhysicalMediaViewModel as the data context for the view
        /// </summary>
        public LearningResourcePhysicalMediaView(ILearningResourcePhysicalMediaViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
