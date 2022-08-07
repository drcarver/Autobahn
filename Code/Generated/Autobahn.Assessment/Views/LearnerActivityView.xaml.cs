//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   LearnerActivityView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The LearnerActivityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearnerActivityView : ContentPage
    {
        /// <summary>
        /// Inject the ILearnerActivityViewModel as the data context for the view
        /// </summary>
        public LearnerActivityView(ILearnerActivityViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
