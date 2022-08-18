//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationEmailView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationEmailView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationEmailView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationEmail View Model as the data context for the view
        /// </summary>
        public OrganizationEmailView(Interfaces.IOrganizationEmail vm)
        {
            BindingContext  = vm;
        }
    }
}
