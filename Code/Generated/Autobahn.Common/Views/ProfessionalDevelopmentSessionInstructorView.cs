//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProfessionalDevelopmentSessionInstructorView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ProfessionalDevelopmentSessionInstructorView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfessionalDevelopmentSessionInstructorView : ContentPage
    {
        /// <summary>
        /// Inject the ProfessionalDevelopmentSessionInstructorViewModel as the data context for the view
        /// </summary>
        public ProfessionalDevelopmentSessionInstructorView(ProfessionalDevelopmentSessionInstructorViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
