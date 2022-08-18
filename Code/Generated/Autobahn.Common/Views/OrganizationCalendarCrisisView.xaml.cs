//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarCrisisView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationCalendarCrisisView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationCalendarCrisisView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationCalendarCrisis View Model as the data context for the view
        /// </summary>
        public OrganizationCalendarCrisisView(Interfaces.IOrganizationCalendarCrisis vm)
        {
            BindingContext  = vm;
        }
    }
}
