//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SeaView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12SeaView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12SeaView : ContentPage
    {
        /// <summary>
        /// Inject the K12SeaViewModel as the data context for the view
        /// </summary>
        public K12SeaView(K12SeaViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
