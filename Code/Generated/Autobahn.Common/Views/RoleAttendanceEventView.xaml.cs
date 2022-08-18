//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleAttendanceEventView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The RoleAttendanceEventView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoleAttendanceEventView : ContentPage
    {
        /// <summary>
        /// Inject the IRoleAttendanceEvent View Model as the data context for the view
        /// </summary>
        public RoleAttendanceEventView(Interfaces.IRoleAttendanceEvent vm)
        {
            BindingContext  = vm;
        }
    }
}
