//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleRelationshipView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationPersonRoleRelationshipView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationPersonRoleRelationshipView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationPersonRoleRelationship View Model as the data context for the view
        /// </summary>
        public OrganizationPersonRoleRelationshipView(Interfaces.IOrganizationPersonRoleRelationship vm)
        {
            BindingContext  = vm;
        }
    }
}
