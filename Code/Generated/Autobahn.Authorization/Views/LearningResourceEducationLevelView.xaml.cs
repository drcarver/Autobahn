//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   LearningResourceEducationLevelView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The LearningResourceEducationLevelView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearningResourceEducationLevelView : ContentPage
    {
        /// <summary>
        /// Inject the ILearningResourceEducationLevel View Model as the data context for the view
        /// </summary>
        public LearningResourceEducationLevelView(Interfaces.ILearningResourceEducationLevel vm)
        {
            BindingContext  = vm;
        }
    }
}
