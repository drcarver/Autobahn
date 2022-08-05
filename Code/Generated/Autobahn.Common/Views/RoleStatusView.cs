//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RoleStatusView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The RoleStatusView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoleStatusView : ContentPage
    {
        /// <summary>
        /// Inject the RoleStatusViewModel as the data context for the view
        /// </summary>
        public RoleStatusView(RoleStatusViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
