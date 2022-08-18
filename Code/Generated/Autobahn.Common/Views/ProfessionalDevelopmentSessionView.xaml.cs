//**********************************************************
//* DomainName: Common Models
//* FileName:   ProfessionalDevelopmentSessionView.cs
//**********************************************************

namespace Autobahn.Common.Views
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
