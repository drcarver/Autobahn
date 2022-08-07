//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProfessionalDevelopmentRequirementView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ProfessionalDevelopmentRequirementView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfessionalDevelopmentRequirementView : ContentPage
    {
        /// <summary>
        /// Inject the IProfessionalDevelopmentRequirementViewModel as the data context for the view
        /// </summary>
        public ProfessionalDevelopmentRequirementView(IProfessionalDevelopmentRequirementViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
