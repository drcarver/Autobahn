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
        /// Inject the IProfessionalDevelopmentSessionInstructorViewModel as the data context for the view
        /// </summary>
        public ProfessionalDevelopmentSessionInstructorView(IProfessionalDevelopmentSessionInstructorViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
