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
        /// Inject the OrganizationPersonRoleRelationshipViewModel as the data context for the view
        /// </summary>
        public OrganizationPersonRoleRelationshipView(OrganizationPersonRoleRelationshipViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
