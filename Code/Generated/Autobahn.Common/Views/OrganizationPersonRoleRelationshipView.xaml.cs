//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPersonRoleRelationshipView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationPersonRoleRelationshipView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationPersonRoleRelationshipView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationPersonRoleRelationshipViewModel as the data context for the view
        /// </summary>
        public OrganizationPersonRoleRelationshipView(IOrganizationPersonRoleRelationshipViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
