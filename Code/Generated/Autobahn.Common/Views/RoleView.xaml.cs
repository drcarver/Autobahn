//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The RoleView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoleView : ContentPage
    {
        /// <summary>
        /// Inject the IRole View Model as the data context for the view
        /// </summary>
        public RoleView(Interfaces.IRole vm)
        {
            BindingContext  = vm;
        }
    }
}
