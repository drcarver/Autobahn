//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SeaView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12SeaView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12SeaView : ContentPage
    {
        /// <summary>
        /// Inject the IK12Sea View Model as the data context for the view
        /// </summary>
        public K12SeaView(Interfaces.IK12Sea vm)
        {
            BindingContext  = vm;
        }
    }
}
