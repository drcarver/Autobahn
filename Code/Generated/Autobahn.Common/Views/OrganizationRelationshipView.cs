//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationRelationshipView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationRelationshipView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationRelationshipView : ContentPage
    {
        /// <summary>
        /// Inject the OrganizationRelationshipViewModel as the data context for the view
        /// </summary>
        public OrganizationRelationshipView(OrganizationRelationshipViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
