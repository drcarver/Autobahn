//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffEmploymentView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The StaffEmploymentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaffEmploymentView : ContentPage
    {
        /// <summary>
        /// Inject the IStaffEmploymentViewModel as the data context for the view
        /// </summary>
        public StaffEmploymentView(IStaffEmploymentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
