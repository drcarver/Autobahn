//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentActivityView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentActivityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentActivityView : ContentPage
    {
        /// <summary>
        /// Inject the K12StudentActivityViewModel as the data context for the view
        /// </summary>
        public K12StudentActivityView(K12StudentActivityViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
