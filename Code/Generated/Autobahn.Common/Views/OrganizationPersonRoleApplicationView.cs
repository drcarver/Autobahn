//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPersonRoleApplicationView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationPersonRoleApplicationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationPersonRoleApplicationView : ContentPage
    {
        /// <summary>
        /// Inject the OrganizationPersonRoleApplicationViewModel as the data context for the view
        /// </summary>
        public OrganizationPersonRoleApplicationView(OrganizationPersonRoleApplicationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
