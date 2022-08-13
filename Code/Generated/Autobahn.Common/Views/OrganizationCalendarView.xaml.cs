//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationCalendarView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationCalendarView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationCalendar View Model as the data context for the view
        /// </summary>
        public OrganizationCalendarView(Interfaces.IOrganizationCalendar vm)
        {
            BindingContext  = vm;
        }
    }
}
