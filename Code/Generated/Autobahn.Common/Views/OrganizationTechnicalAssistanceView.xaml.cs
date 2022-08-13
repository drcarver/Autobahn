//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationTechnicalAssistanceView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationTechnicalAssistanceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationTechnicalAssistanceView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationTechnicalAssistance View Model as the data context for the view
        /// </summary>
        public OrganizationTechnicalAssistanceView(Interfaces.IOrganizationTechnicalAssistance vm)
        {
            BindingContext  = vm;
        }
    }
}
