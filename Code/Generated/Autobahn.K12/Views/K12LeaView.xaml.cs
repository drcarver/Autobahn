//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LeaView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LeaView : ContentPage
    {
        /// <summary>
        /// Inject the IK12Lea View Model as the data context for the view
        /// </summary>
        public K12LeaView(Interfaces.IK12Lea vm)
        {
            BindingContext  = vm;
        }
    }
}
