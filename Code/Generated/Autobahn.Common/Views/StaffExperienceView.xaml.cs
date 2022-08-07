//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffExperienceView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The StaffExperienceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaffExperienceView : ContentPage
    {
        /// <summary>
        /// Inject the IStaffExperienceViewModel as the data context for the view
        /// </summary>
        public StaffExperienceView(IStaffExperienceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
