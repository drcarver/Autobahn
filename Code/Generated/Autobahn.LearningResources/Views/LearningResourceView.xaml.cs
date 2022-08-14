//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceView.cs
//**********************************************************

namespace Autobahn.LearningResources.Views
{
     /// <summary>
     /// The LearningResourceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearningResourceView : ContentPage
    {
        /// <summary>
        /// Inject the ILearningResource View Model as the data context for the view
        /// </summary>
        public LearningResourceView(Interfaces.ILearningResource vm)
        {
            BindingContext  = vm;
        }
    }
}
