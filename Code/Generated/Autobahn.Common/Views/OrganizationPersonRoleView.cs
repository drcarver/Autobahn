//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPersonRoleView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationPersonRoleView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationPersonRoleView : ContentPage
    {
        /// <summary>
        /// Inject the OrganizationPersonRoleViewModel as the data context for the view
        /// </summary>
        public OrganizationPersonRoleView(OrganizationPersonRoleViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
