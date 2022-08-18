//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationImageView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationImageView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationImageView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationImage View Model as the data context for the view
        /// </summary>
        public OrganizationImageView(Interfaces.IOrganizationImage vm)
        {
            BindingContext  = vm;
        }
    }
}
