//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleStatusView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The RoleStatusView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoleStatusView : ContentPage
    {
        /// <summary>
        /// Inject the IRoleStatus View Model as the data context for the view
        /// </summary>
        public RoleStatusView(Interfaces.IRoleStatus vm)
        {
            BindingContext  = vm;
        }
    }
}
