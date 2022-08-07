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
        /// Inject the IRoleStatusViewModel as the data context for the view
        /// </summary>
        public RoleStatusView(IRoleStatusViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
