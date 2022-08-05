//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   AeStudentEmploymentView.cs
//**********************************************************

using Autobahn.AdultEducation.ViewModels;

namespace Autobahn.AdultEducation.Views
{
     /// <summary>
     /// The AeStudentEmploymentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AeStudentEmploymentView : ContentPage
    {
        /// <summary>
        /// Inject the AeStudentEmploymentViewModel as the data context for the view
        /// </summary>
        public AeStudentEmploymentView(AeStudentEmploymentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
