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
        /// Inject the OrganizationTechnicalAssistanceViewModel as the data context for the view
        /// </summary>
        public OrganizationTechnicalAssistanceView(OrganizationTechnicalAssistanceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
