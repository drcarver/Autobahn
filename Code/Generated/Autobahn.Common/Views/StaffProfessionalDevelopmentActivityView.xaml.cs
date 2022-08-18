//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffProfessionalDevelopmentActivityView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The StaffProfessionalDevelopmentActivityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaffProfessionalDevelopmentActivityView : ContentPage
    {
        /// <summary>
        /// Inject the IStaffProfessionalDevelopmentActivity View Model as the data context for the view
        /// </summary>
        public StaffProfessionalDevelopmentActivityView(Interfaces.IStaffProfessionalDevelopmentActivity vm)
        {
            BindingContext  = vm;
        }
    }
}
