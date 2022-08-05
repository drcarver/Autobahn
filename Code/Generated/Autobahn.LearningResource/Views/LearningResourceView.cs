//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   LearningResourceView.cs
//**********************************************************

using Autobahn.LearningResource.ViewModels;

namespace Autobahn.LearningResource.Views
{
     /// <summary>
     /// The LearningResourceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearningResourceView : ContentPage
    {
        /// <summary>
        /// Inject the LearningResourceViewModel as the data context for the view
        /// </summary>
        public LearningResourceView(LearningResourceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
