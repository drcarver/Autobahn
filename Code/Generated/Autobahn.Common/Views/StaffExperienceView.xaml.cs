//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffExperienceView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The StaffExperienceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaffExperienceView : ContentPage
    {
        /// <summary>
        /// Inject the IStaffExperience View Model as the data context for the view
        /// </summary>
        public StaffExperienceView(Interfaces.IStaffExperience vm)
        {
            BindingContext  = vm;
        }
    }
}
