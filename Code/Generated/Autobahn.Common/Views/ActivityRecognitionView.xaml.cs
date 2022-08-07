//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ActivityRecognitionView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ActivityRecognitionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityRecognitionView : ContentPage
    {
        /// <summary>
        /// Inject the IActivityRecognitionViewModel as the data context for the view
        /// </summary>
        public ActivityRecognitionView(IActivityRecognitionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
