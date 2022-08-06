//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationEmployeeBenefitView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationEmployeeBenefitView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationEmployeeBenefitView : ContentPage
    {
        /// <summary>
        /// Inject the OrganizationEmployeeBenefitViewModel as the data context for the view
        /// </summary>
        public OrganizationEmployeeBenefitView(OrganizationEmployeeBenefitViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
