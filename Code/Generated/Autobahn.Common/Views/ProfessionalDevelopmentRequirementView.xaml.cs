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
        /// Inject the ProfessionalDevelopmentRequirementViewModel as the data context for the view
        /// </summary>
        public ProfessionalDevelopmentRequirementView(ProfessionalDevelopmentRequirementViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
