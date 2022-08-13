//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarDayView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationCalendarDayView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationCalendarDayView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationCalendarDay View Model as the data context for the view
        /// </summary>
        public OrganizationCalendarDayView(Interfaces.IOrganizationCalendarDay vm)
        {
            BindingContext  = vm;
        }
    }
}
