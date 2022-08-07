//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LeaView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LeaView : ContentPage
    {
        /// <summary>
        /// Inject the IK12LeaViewModel as the data context for the view
        /// </summary>
        public K12LeaView(IK12LeaViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
