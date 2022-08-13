//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolStatusView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12SchoolStatusView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12SchoolStatusView : ContentPage
    {
        /// <summary>
        /// Inject the IK12SchoolStatus View Model as the data context for the view
        /// </summary>
        public K12SchoolStatusView(Interfaces.IK12SchoolStatus vm)
        {
            BindingContext  = vm;
        }
    }
}
