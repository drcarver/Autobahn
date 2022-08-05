//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPersonRoleFTEView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationPersonRoleFTEView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationPersonRoleFTEView : ContentPage
    {
        /// <summary>
        /// Inject the OrganizationPersonRoleFTEViewModel as the data context for the view
        /// </summary>
        public OrganizationPersonRoleFTEView(OrganizationPersonRoleFTEViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
