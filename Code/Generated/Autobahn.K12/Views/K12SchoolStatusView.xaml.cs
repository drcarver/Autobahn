//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolStatusView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12SchoolStatusView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12SchoolStatusView : ContentPage
    {
        /// <summary>
        /// Inject the IK12SchoolStatusViewModel as the data context for the view
        /// </summary>
        public K12SchoolStatusView(IK12SchoolStatusViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
