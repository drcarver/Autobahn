//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleFTEView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationPersonRoleFTEView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationPersonRoleFTEView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationPersonRoleFTE View Model as the data context for the view
        /// </summary>
        public OrganizationPersonRoleFTEView(Interfaces.IOrganizationPersonRoleFTE vm)
        {
            BindingContext  = vm;
        }
    }
}
