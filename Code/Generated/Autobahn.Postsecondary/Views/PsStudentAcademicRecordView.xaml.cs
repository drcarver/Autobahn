//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentAcademicRecordView.cs
//**********************************************************

using Autobahn.Postsecondary.ViewModels;

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentAcademicRecordView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentAcademicRecordView : ContentPage
    {
        /// <summary>
        /// Inject the IPsStudentAcademicRecordViewModel as the data context for the view
        /// </summary>
        public PsStudentAcademicRecordView(IPsStudentAcademicRecordViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
