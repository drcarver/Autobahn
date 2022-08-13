//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProfessionalDevelopmentRequirementView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The ProfessionalDevelopmentRequirementView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfessionalDevelopmentRequirementView : ContentPage
    {
        /// <summary>
        /// Inject the IProfessionalDevelopmentRequirement View Model as the data context for the view
        /// </summary>
        public ProfessionalDevelopmentRequirementView(Interfaces.IProfessionalDevelopmentRequirement vm)
        {
            BindingContext  = vm;
        }
    }
}
