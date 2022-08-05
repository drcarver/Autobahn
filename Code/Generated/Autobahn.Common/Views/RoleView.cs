//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RoleView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The RoleView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoleView : ContentPage
    {
        /// <summary>
        /// Inject the RoleViewModel as the data context for the view
        /// </summary>
        public RoleView(RoleViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}