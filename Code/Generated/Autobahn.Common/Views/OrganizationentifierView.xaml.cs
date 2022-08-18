//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationentifierView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationentifierView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationentifierView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationentifier View Model as the data context for the view
        /// </summary>
        public OrganizationentifierView(Interfaces.IOrganizationentifier vm)
        {
            BindingContext  = vm;
        }
    }
}
