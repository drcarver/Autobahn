//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleAttendanceView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The RoleAttendanceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoleAttendanceView : ContentPage
    {
        /// <summary>
        /// Inject the IRoleAttendance View Model as the data context for the view
        /// </summary>
        public RoleAttendanceView(Interfaces.IRoleAttendance vm)
        {
            BindingContext  = vm;
        }
    }
}
