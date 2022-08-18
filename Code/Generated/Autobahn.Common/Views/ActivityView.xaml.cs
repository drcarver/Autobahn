//**********************************************************
//* DomainName: Common Models
//* FileName:   ActivityView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ActivityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityView : ContentPage
    {
        /// <summary>
        /// Inject the IActivity View Model as the data context for the view
        /// </summary>
        public ActivityView(Interfaces.IActivity vm)
        {
            BindingContext  = vm;
        }
    }
}
