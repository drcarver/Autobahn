//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarEventView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationCalendarEventView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationCalendarEventView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationCalendarEvent View Model as the data context for the view
        /// </summary>
        public OrganizationCalendarEventView(Interfaces.IOrganizationCalendarEvent vm)
        {
            BindingContext  = vm;
        }
    }
}
