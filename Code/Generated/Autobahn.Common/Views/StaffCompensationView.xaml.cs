//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffCompensationView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The StaffCompensationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaffCompensationView : ContentPage
    {
        /// <summary>
        /// Inject the IStaffCompensation View Model as the data context for the view
        /// </summary>
        public StaffCompensationView(Interfaces.IStaffCompensation vm)
        {
            BindingContext  = vm;
        }
    }
}
