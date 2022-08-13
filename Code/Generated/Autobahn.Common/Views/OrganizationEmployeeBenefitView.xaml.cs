//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationEmployeeBenefitView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationEmployeeBenefitView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationEmployeeBenefitView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationEmployeeBenefit View Model as the data context for the view
        /// </summary>
        public OrganizationEmployeeBenefitView(Interfaces.IOrganizationEmployeeBenefit vm)
        {
            BindingContext  = vm;
        }
    }
}
