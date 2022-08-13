//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   LearningResourcePhysicalMediaView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The LearningResourcePhysicalMediaView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearningResourcePhysicalMediaView : ContentPage
    {
        /// <summary>
        /// Inject the ILearningResourcePhysicalMedia View Model as the data context for the view
        /// </summary>
        public LearningResourcePhysicalMediaView(Interfaces.ILearningResourcePhysicalMedia vm)
        {
            BindingContext  = vm;
        }
    }
}
