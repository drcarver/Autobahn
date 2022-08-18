//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolIndicatorStatusView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12SchoolIndicatorStatusView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12SchoolIndicatorStatusView : ContentPage
    {
        /// <summary>
        /// Inject the IK12SchoolIndicatorStatus View Model as the data context for the view
        /// </summary>
        public K12SchoolIndicatorStatusView(Interfaces.IK12SchoolIndicatorStatus vm)
        {
            BindingContext  = vm;
        }
    }
}
