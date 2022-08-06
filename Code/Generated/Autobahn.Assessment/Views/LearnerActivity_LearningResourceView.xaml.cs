//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   LearnerActivity_LearningResourceView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The LearnerActivity_LearningResourceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearnerActivity_LearningResourceView : ContentPage
    {
        /// <summary>
        /// Inject the LearnerActivity_LearningResourceViewModel as the data context for the view
        /// </summary>
        public LearnerActivity_LearningResourceView(LearnerActivity_LearningResourceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
