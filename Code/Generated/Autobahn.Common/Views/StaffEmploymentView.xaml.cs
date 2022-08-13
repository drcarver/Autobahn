//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEmploymentView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The StaffEmploymentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaffEmploymentView : ContentPage
    {
        /// <summary>
        /// Inject the IStaffEmployment View Model as the data context for the view
        /// </summary>
        public StaffEmploymentView(Interfaces.IStaffEmployment vm)
        {
            BindingContext  = vm;
        }
    }
}
