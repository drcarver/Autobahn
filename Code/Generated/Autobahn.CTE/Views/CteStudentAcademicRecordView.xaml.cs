//**********************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   CteStudentAcademicRecordView.cs
//**********************************************************

namespace Autobahn.CTE.Views
{
     /// <summary>
     /// The CteStudentAcademicRecordView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CteStudentAcademicRecordView : ContentPage
    {
        /// <summary>
        /// Inject the ICteStudentAcademicRecord View Model as the data context for the view
        /// </summary>
        public CteStudentAcademicRecordView(Interfaces.ICteStudentAcademicRecord vm)
        {
            BindingContext  = vm;
        }
    }
}
