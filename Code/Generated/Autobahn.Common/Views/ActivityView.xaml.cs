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
        /// Inject the ActivityViewModel as the data context for the view
        /// </summary>
        public ActivityView(ActivityViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
