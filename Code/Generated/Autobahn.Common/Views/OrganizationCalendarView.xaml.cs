//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationCalendarView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationCalendarView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationCalendarView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationCalendarViewModel as the data context for the view
        /// </summary>
        public OrganizationCalendarView(IOrganizationCalendarViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
