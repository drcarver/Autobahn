//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProfessionalDevelopmentSessionInstructorView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The ProfessionalDevelopmentSessionInstructorView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfessionalDevelopmentSessionInstructorView : ContentPage
    {
        /// <summary>
        /// Inject the IProfessionalDevelopmentSessionInstructor View Model as the data context for the view
        /// </summary>
        public ProfessionalDevelopmentSessionInstructorView(Interfaces.IProfessionalDevelopmentSessionInstructor vm)
        {
            BindingContext  = vm;
        }
    }
}
