//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProfessionalDevelopmentActivityView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ProfessionalDevelopmentActivityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfessionalDevelopmentActivityView : ContentPage
    {
        /// <summary>
        /// Inject the ProfessionalDevelopmentActivityViewModel as the data context for the view
        /// </summary>
        public ProfessionalDevelopmentActivityView(ProfessionalDevelopmentActivityViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
