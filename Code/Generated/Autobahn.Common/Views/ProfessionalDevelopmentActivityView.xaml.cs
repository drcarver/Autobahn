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
        /// Inject the IProfessionalDevelopmentActivityViewModel as the data context for the view
        /// </summary>
        public ProfessionalDevelopmentActivityView(IProfessionalDevelopmentActivityViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
