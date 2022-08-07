//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   LearnerActionView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The LearnerActionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearnerActionView : ContentPage
    {
        /// <summary>
        /// Inject the ILearnerActionViewModel as the data context for the view
        /// </summary>
        public LearnerActionView(ILearnerActionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
