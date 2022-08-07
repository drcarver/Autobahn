//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   LearningResourceEducationLevelView.cs
//**********************************************************

using Autobahn.LearningResource.ViewModels;

namespace Autobahn.LearningResource.Views
{
     /// <summary>
     /// The LearningResourceEducationLevelView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearningResourceEducationLevelView : ContentPage
    {
        /// <summary>
        /// Inject the ILearningResourceEducationLevelViewModel as the data context for the view
        /// </summary>
        public LearningResourceEducationLevelView(ILearningResourceEducationLevelViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
