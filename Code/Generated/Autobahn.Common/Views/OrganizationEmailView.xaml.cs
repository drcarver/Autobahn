//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationEmailView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationEmailView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationEmailView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationEmailViewModel as the data context for the view
        /// </summary>
        public OrganizationEmailView(IOrganizationEmailViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
