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
        /// Inject the ICteStudentAcademicRecordViewModel as the data context for the view
        /// </summary>
        public CteStudentAcademicRecordView(ICteStudentAcademicRecordViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
