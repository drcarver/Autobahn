//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RoleAttendanceEventView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The RoleAttendanceEventView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoleAttendanceEventView : ContentPage
    {
        /// <summary>
        /// Inject the IRoleAttendanceEventViewModel as the data context for the view
        /// </summary>
        public RoleAttendanceEventView(IRoleAttendanceEventViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
