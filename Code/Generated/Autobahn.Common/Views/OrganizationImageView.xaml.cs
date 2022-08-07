//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationImageView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationImageView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationImageView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationImageViewModel as the data context for the view
        /// </summary>
        public OrganizationImageView(IOrganizationImageViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
