//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeStudentEmploymentView.cs
//**********************************************************

namespace Autobahn.AdultEducation.Views
{
     /// <summary>
     /// The AeStudentEmploymentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AeStudentEmploymentView : ContentPage
    {
        /// <summary>
        /// Inject the IAeStudentEmployment View Model as the data context for the view
        /// </summary>
        public AeStudentEmploymentView(Interfaces.IAeStudentEmployment vm)
        {
            BindingContext  = vm;
        }
    }
}
