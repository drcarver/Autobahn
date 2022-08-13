//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPolicyView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationPolicyView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationPolicyView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationPolicy View Model as the data context for the view
        /// </summary>
        public OrganizationPolicyView(Interfaces.IOrganizationPolicy vm)
        {
            BindingContext  = vm;
        }
    }
}
