//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPolicyView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationPolicyView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationPolicyView : ContentPage
    {
        /// <summary>
        /// Inject the OrganizationPolicyViewModel as the data context for the view
        /// </summary>
        public OrganizationPolicyView(OrganizationPolicyViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}