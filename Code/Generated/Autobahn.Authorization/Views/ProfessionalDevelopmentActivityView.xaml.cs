//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProfessionalDevelopmentActivityView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The ProfessionalDevelopmentActivityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfessionalDevelopmentActivityView : ContentPage
    {
        /// <summary>
        /// Inject the IProfessionalDevelopmentActivity View Model as the data context for the view
        /// </summary>
        public ProfessionalDevelopmentActivityView(Interfaces.IProfessionalDevelopmentActivity vm)
        {
            BindingContext  = vm;
        }
    }
}
