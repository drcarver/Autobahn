//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ActivityView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ActivityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityView : ContentPage
    {
        /// <summary>
        /// Inject the IActivityViewModel as the data context for the view
        /// </summary>
        public ActivityView(IActivityViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
