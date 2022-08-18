//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationRelationshipView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationRelationshipView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationRelationshipView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationRelationship View Model as the data context for the view
        /// </summary>
        public OrganizationRelationshipView(Interfaces.IOrganizationRelationship vm)
        {
            BindingContext  = vm;
        }
    }
}
