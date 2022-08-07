//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationTechnicalAssistanceView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationTechnicalAssistanceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationTechnicalAssistanceView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationTechnicalAssistanceViewModel as the data context for the view
        /// </summary>
        public OrganizationTechnicalAssistanceView(IOrganizationTechnicalAssistanceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
