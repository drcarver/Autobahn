//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationCalendarSessionView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationCalendarSessionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationCalendarSessionView : ContentPage
    {
        /// <summary>
        /// Inject the OrganizationCalendarSessionViewModel as the data context for the view
        /// </summary>
        public OrganizationCalendarSessionView(OrganizationCalendarSessionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
