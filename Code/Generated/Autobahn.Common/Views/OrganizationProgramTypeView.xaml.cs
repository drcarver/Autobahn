//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationProgramTypeView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationProgramTypeView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationProgramTypeView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationProgramType View Model as the data context for the view
        /// </summary>
        public OrganizationProgramTypeView(Interfaces.IOrganizationProgramType vm)
        {
            BindingContext  = vm;
        }
    }
}
