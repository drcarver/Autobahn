//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProfessionalDevelopmentSessionView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ProfessionalDevelopmentSessionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfessionalDevelopmentSessionView : ContentPage
    {
        /// <summary>
        /// Inject the ProfessionalDevelopmentSessionViewModel as the data context for the view
        /// </summary>
        public ProfessionalDevelopmentSessionView(ProfessionalDevelopmentSessionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
