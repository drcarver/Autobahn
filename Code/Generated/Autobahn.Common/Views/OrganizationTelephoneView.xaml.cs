//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationTelephoneView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationTelephoneView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationTelephoneView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationTelephoneViewModel as the data context for the view
        /// </summary>
        public OrganizationTelephoneView(IOrganizationTelephoneViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
