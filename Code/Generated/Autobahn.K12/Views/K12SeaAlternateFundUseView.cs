//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SeaAlternateFundUseView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12SeaAlternateFundUseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12SeaAlternateFundUseView : ContentPage
    {
        /// <summary>
        /// Inject the K12SeaAlternateFundUseViewModel as the data context for the view
        /// </summary>
        public K12SeaAlternateFundUseView(K12SeaAlternateFundUseViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
