//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeStudentAcademicRecordView.cs
//**********************************************************

namespace Autobahn.AdultEducation.Views
{
     /// <summary>
     /// The AeStudentAcademicRecordView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AeStudentAcademicRecordView : ContentPage
    {
        /// <summary>
        /// Inject the IAeStudentAcademicRecord View Model as the data context for the view
        /// </summary>
        public AeStudentAcademicRecordView(Interfaces.IAeStudentAcademicRecord vm)
        {
            BindingContext  = vm;
        }
    }
}
