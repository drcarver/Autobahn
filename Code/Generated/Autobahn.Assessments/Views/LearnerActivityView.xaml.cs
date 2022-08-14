//**********************************************************
//* DomainName: Assessments
//* FileName:   LearnerActivityView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The LearnerActivityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearnerActivityView : ContentPage
    {
        /// <summary>
        /// Inject the ILearnerActivity View Model as the data context for the view
        /// </summary>
        public LearnerActivityView(Interfaces.ILearnerActivity vm)
        {
            BindingContext  = vm;
        }
    }
}
