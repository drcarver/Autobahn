//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarSessionView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationCalendarSessionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationCalendarSessionView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationCalendarSession View Model as the data context for the view
        /// </summary>
        public OrganizationCalendarSessionView(Interfaces.IOrganizationCalendarSession vm)
        {
            BindingContext  = vm;
        }
    }
}
