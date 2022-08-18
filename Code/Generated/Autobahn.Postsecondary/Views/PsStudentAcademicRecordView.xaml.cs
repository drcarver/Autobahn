//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAcademicRecordView.cs
//**********************************************************

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentAcademicRecordView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentAcademicRecordView : ContentPage
    {
        /// <summary>
        /// Inject the IPsStudentAcademicRecord View Model as the data context for the view
        /// </summary>
        public PsStudentAcademicRecordView(Interfaces.IPsStudentAcademicRecord vm)
        {
            BindingContext  = vm;
        }
    }
}
