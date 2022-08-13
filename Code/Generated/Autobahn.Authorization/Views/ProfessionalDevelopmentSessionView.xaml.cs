//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProfessionalDevelopmentSessionView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The ProfessionalDevelopmentSessionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfessionalDevelopmentSessionView : ContentPage
    {
        /// <summary>
        /// Inject the IProfessionalDevelopmentSession View Model as the data context for the view
        /// </summary>
        public ProfessionalDevelopmentSessionView(Interfaces.IProfessionalDevelopmentSession vm)
        {
            BindingContext  = vm;
        }
    }
}
