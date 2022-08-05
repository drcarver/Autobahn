//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolIndicatorStatusView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12SchoolIndicatorStatusView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12SchoolIndicatorStatusView : ContentPage
    {
        /// <summary>
        /// Inject the K12SchoolIndicatorStatusViewModel as the data context for the view
        /// </summary>
        public K12SchoolIndicatorStatusView(K12SchoolIndicatorStatusViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
