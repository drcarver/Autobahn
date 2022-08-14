//**********************************************************
//* DomainName: Assessments
//* FileName:   LearnerActivity_LearningResourceView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The LearnerActivity_LearningResourceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearnerActivity_LearningResourceView : ContentPage
    {
        /// <summary>
        /// Inject the ILearnerActivity_LearningResource View Model as the data context for the view
        /// </summary>
        public LearnerActivity_LearningResourceView(Interfaces.ILearnerActivity_LearningResource vm)
        {
            BindingContext  = vm;
        }
    }
}
