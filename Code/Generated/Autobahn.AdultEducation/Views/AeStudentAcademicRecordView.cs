//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   AeStudentAcademicRecordView.cs
//**********************************************************

using Autobahn.AdultEducation.ViewModels;

namespace Autobahn.AdultEducation.Views
{
     /// <summary>
     /// The AeStudentAcademicRecordView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AeStudentAcademicRecordView : ContentPage
    {
        /// <summary>
        /// Inject the AeStudentAcademicRecordViewModel as the data context for the view
        /// </summary>
        public AeStudentAcademicRecordView(AeStudentAcademicRecordViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}