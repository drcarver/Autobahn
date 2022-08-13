//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarCrisiView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationCalendarCrisiView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationCalendarCrisiView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationCalendarCrisi View Model as the data context for the view
        /// </summary>
        public OrganizationCalendarCrisiView(Interfaces.IOrganizationCalendarCrisi vm)
        {
            BindingContext  = vm;
        }
    }
}
