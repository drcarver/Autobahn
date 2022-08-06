//**********************************************************
//* DomainName: Autobahn.CareerandTechnical
//* FileName:   CteStudentAcademicRecordView.cs
//**********************************************************

using Autobahn.CareerandTechnical.ViewModels;

namespace Autobahn.CareerandTechnical.Views
{
     /// <summary>
     /// The CteStudentAcademicRecordView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CteStudentAcademicRecordView : ContentPage
    {
        /// <summary>
        /// Inject the CteStudentAcademicRecordViewModel as the data context for the view
        /// </summary>
        public CteStudentAcademicRecordView(CteStudentAcademicRecordViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
