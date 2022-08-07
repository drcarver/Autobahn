//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationCalendarDayView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationCalendarDayView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationCalendarDayView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationCalendarDayViewModel as the data context for the view
        /// </summary>
        public OrganizationCalendarDayView(IOrganizationCalendarDayViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
