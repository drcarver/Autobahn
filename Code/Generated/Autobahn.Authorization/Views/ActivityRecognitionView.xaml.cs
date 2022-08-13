//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ActivityRecognitionView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The ActivityRecognitionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityRecognitionView : ContentPage
    {
        /// <summary>
        /// Inject the IActivityRecognition View Model as the data context for the view
        /// </summary>
        public ActivityRecognitionView(Interfaces.IActivityRecognition vm)
        {
            BindingContext  = vm;
        }
    }
}
