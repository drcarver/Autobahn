//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationCalendarEventView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationCalendarEventView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationCalendarEventView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationCalendarEventViewModel as the data context for the view
        /// </summary>
        public OrganizationCalendarEventView(IOrganizationCalendarEventViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
