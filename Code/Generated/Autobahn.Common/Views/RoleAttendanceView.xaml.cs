//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RoleAttendanceView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The RoleAttendanceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoleAttendanceView : ContentPage
    {
        /// <summary>
        /// Inject the IRoleAttendanceViewModel as the data context for the view
        /// </summary>
        public RoleAttendanceView(IRoleAttendanceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
