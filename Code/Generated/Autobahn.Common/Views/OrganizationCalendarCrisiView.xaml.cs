//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationCalendarCrisiView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationCalendarCrisiView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationCalendarCrisiView : ContentPage
    {
        /// <summary>
        /// Inject the OrganizationCalendarCrisiViewModel as the data context for the view
        /// </summary>
        public OrganizationCalendarCrisiView(OrganizationCalendarCrisiViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
