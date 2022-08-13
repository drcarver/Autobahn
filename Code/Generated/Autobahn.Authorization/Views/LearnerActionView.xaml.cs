//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   LearnerActionView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The LearnerActionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearnerActionView : ContentPage
    {
        /// <summary>
        /// Inject the ILearnerAction View Model as the data context for the view
        /// </summary>
        public LearnerActionView(Interfaces.ILearnerAction vm)
        {
            BindingContext  = vm;
        }
    }
}
