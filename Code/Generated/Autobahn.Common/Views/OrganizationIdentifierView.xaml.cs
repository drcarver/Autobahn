//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationIdentifierView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationIdentifierView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationIdentifierView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationIdentifier View Model as the data context for the view
        /// </summary>
        public OrganizationIdentifierView(Interfaces.IOrganizationIdentifier vm)
        {
            BindingContext  = vm;
        }
    }
}
